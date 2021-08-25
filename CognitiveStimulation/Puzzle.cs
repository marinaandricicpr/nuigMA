 using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

using ImageProcessing;
using Cognitive_Stimulation.Properties;

using System.IO;

namespace Cognitive_Stimulation
{
    public partial class Puzzle : Form
    {
        CommonFunctions common = new CommonFunctions(1);

        int usedtime = 0;

        private bool _victoryAnnounced;

        private bool _canMovePiece;

        private int _previousMouseX, _previousMouseY;

        private int _previousClientWidth, _previousClientHeight;

        private int _puzzlePictureWidth, _puzzlePictureHeight;

        private Bitmap _board;

        private Bitmap _backBuffer;

        private Bitmap _background;

        private Bitmap _sourcePicture;

        private PieceCluster _currentCluster;

        List<PieceCluster> _clusters = new List<PieceCluster>();

        public Puzzle()
        {
            InitializeComponent(); 
        }

        private void PuzzleSlide_Load(object sender, EventArgs e)
        {
            _previousClientWidth = this.ClientSize.Width;
            _previousClientHeight = this.ClientSize.Height;
            _puzzlePictureWidth = this.ClientSize.Width - panel2.Width - 300 - 100;
            _puzzlePictureHeight = this.ClientSize.Height - panel1.Height;
        }

        private void Puzzle_Paint(object sender, PaintEventArgs e)
        {
            if (_board != null)
            {
                using (Graphics gfx = this.CreateGraphics())
                {
                    gfx.DrawImageUnscaled(_board, 0, 0);
                }
            }
        }

        private void Puzzle_ClientSizeChanged(object sender, EventArgs e)
        {
            if (_previousClientWidth != this.ClientSize.Width || _previousClientHeight != this.ClientSize.Height)
            {
                _previousClientWidth = this.ClientSize.Width;
                _previousClientHeight = this.ClientSize.Height;

                DisplayCognitive_Stimulation(Settings.Default.ShowImageHint);
            }
        }

        private void Puzzle_MouseDown(object sender, MouseEventArgs e)
        {
            int selectedIndex = -1;

            for (int index = (_clusters.Count - 1); index >= 0; index--)
            {
                if (_clusters[index].MovableFigure.IsVisible(e.X, e.Y))
                {
                    selectedIndex = index;
                    break;
                }
            }

            if (selectedIndex >= 0)
            {
                _currentCluster = _clusters[selectedIndex];

                _clusters.RemoveAt(selectedIndex);
                _clusters.Add(_currentCluster);

                using (Graphics gfx = Graphics.FromImage(_backBuffer))
                {
                    Rectangle currentClusterEndLocation = _currentCluster.EndLocation;

                    // Clear the area with the background picture first
                    gfx.DrawImage(_background, currentClusterEndLocation, currentClusterEndLocation, GraphicsUnit.Pixel);
 
                    Region currentClusterEndLocationRegion = new Region(_currentCluster.EndLocation);

                    foreach (PieceCluster cluster in _clusters)
                    {
                        if (cluster != _currentCluster)
                        {
                            Region clusterRegion = new Region(cluster.MovableFigure);
                            clusterRegion.Intersect(currentClusterEndLocationRegion);

                            if (!clusterRegion.IsEmpty(gfx))
                            {
                                gfx.SetClip(clusterRegion, CombineMode.Replace);
                                gfx.DrawImageUnscaled(cluster.Picture, cluster.EndLocation);
                            }
                        }
                    }
                     
                }

                Matrix matrix = new Matrix();
                SolidBrush shadowBrush = new SolidBrush(GameSettings.DROP_SHADOW_COLOR);

                using (Graphics gfx = Graphics.FromImage(_board))
                { 

                    // Simple drop shadow only for now. Alpha-blended drop shadow is too slow and jerky.
                    matrix.Reset();
                    matrix.Translate(GameSettings.DROP_SHADOW_DEPTH, GameSettings.DROP_SHADOW_DEPTH);

                    GraphicsPath shadowFigure = (GraphicsPath)_currentCluster.MovableFigure.Clone();
                    shadowFigure.Transform(matrix);

                    gfx.ResetClip();
                    gfx.SetClip(shadowFigure);
                    gfx.FillPath(shadowBrush, shadowFigure);
                     
                    gfx.ResetClip();
                    gfx.SetClip(_currentCluster.MovableFigure);
                    gfx.DrawImageUnscaled(_currentCluster.Picture, _currentCluster.EndLocation);
                     
                }

                using (Graphics gfx = this.CreateGraphics())
                {
                    gfx.DrawImageUnscaled(_board, 0, 0);
                }

                _previousMouseX = e.X;
                _previousMouseY = e.Y;

                _canMovePiece = true;
            }
        }

        private void Puzzle_MouseMove(object sender, MouseEventArgs e)
        {
            if (_canMovePiece)
            {
                int offsetX = e.X - _previousMouseX;
                int offsetY = e.Y - _previousMouseY;

                Rectangle currentClusterEndLocation = _currentCluster.EndLocation;

                int clusterOldX = currentClusterEndLocation.X;
                int clusterOldY = currentClusterEndLocation.Y;

                int clusterNewX = currentClusterEndLocation.X + offsetX;
                int clusterNewY = currentClusterEndLocation.Y + offsetY;

                Rectangle clusterOldEndLocation = new Rectangle(clusterOldX, clusterOldY,
                                                        currentClusterEndLocation.Width + GameSettings.DROP_SHADOW_DEPTH,
                                                        currentClusterEndLocation.Height + GameSettings.DROP_SHADOW_DEPTH);

                Rectangle clusterNewEndLocation = new Rectangle(clusterNewX, clusterNewY,
                                                        currentClusterEndLocation.Width + GameSettings.DROP_SHADOW_DEPTH,
                                                        currentClusterEndLocation.Height + GameSettings.DROP_SHADOW_DEPTH);

                Rectangle combinedClusterRect = Rectangle.Union(clusterOldEndLocation, clusterNewEndLocation);
                SolidBrush shadowBrush = new SolidBrush(GameSettings.DROP_SHADOW_COLOR);
                Matrix matrix = new Matrix();

                using (Graphics gfx = Graphics.FromImage(_board))
                {
                    gfx.DrawImage(_backBuffer, combinedClusterRect, combinedClusterRect, GraphicsUnit.Pixel);

                    matrix.Reset();
                    matrix.Translate(offsetX + GameSettings.DROP_SHADOW_DEPTH, offsetY + GameSettings.DROP_SHADOW_DEPTH);

                    GraphicsPath shadowFigure = (GraphicsPath)_currentCluster.MovableFigure.Clone();
                    shadowFigure.Transform(matrix);
                    gfx.FillPath(shadowBrush, shadowFigure);

                    _currentCluster.EndLocation = new Rectangle(clusterNewX, clusterNewY, _currentCluster.Width, _currentCluster.Height);

                    matrix.Reset();
                    matrix.Translate(offsetX, offsetY);
                    _currentCluster.MovableFigure.Transform(matrix);

                    gfx.ResetClip();
                    gfx.SetClip(_currentCluster.MovableFigure);
                    gfx.DrawImageUnscaled(_currentCluster.Picture, _currentCluster.EndLocation);


                    foreach (Piece piece in _currentCluster.Pieces)
                    {
                        int pieceNewX = piece.EndLocation.X + offsetX;
                        int pieceNewY = piece.EndLocation.Y + offsetY;
                        piece.EndLocation = new Rectangle(pieceNewX, pieceNewY, piece.Width, piece.Height);

                        matrix.Reset();
                        matrix.Translate(offsetX, offsetY);
                        piece.MovableFigure.Transform(matrix);
                    }

                }

                using (Graphics gfx = this.CreateGraphics())
                {
                    gfx.DrawImage(_board, combinedClusterRect, combinedClusterRect, GraphicsUnit.Pixel);
                }

                _previousMouseX = e.X;
                _previousMouseY = e.Y;
            }
        }

        private void Puzzle_MouseUp(object sender, MouseEventArgs e)
        {
            if (_canMovePiece)
            {
                _previousMouseX = e.X;
                _previousMouseY = e.Y;

                using (Graphics gfx = Graphics.FromImage(_backBuffer))
                {
                    gfx.ResetClip();
                    gfx.SetClip(_currentCluster.MovableFigure);
                    gfx.DrawImageUnscaled(_currentCluster.Picture, _currentCluster.EndLocation);
                }

                using (Graphics gfx = Graphics.FromImage(_board))
                {
                    gfx.DrawImageUnscaled(_backBuffer, 0, 0);
                }

                using (Graphics gfx = this.CreateGraphics())
                {
                    gfx.DrawImageUnscaled(_backBuffer, 0, 0);
                }

                Matrix matrix = new Matrix();

                List<int> NextInPieceID = new List<int>();

                for (int i = 0; i < _currentCluster.Pieces.Count; i++)
                {
                    Piece currentPiece = _currentCluster.Pieces[i];

                    foreach (int pieceID in currentPiece.NextInPieceID)
                    {
                        Piece adjacentPiece = GetPieceByID(pieceID);

                        if (adjacentPiece != null && (adjacentPiece.PieceID != currentPiece.PieceID))
                        {
                            Rectangle adjacentPieceMovableFigureEndLocation = Rectangle.Truncate(adjacentPiece.MovableFigure.GetBounds());
                            Rectangle currentPieceMovableFigureEndLocation = Rectangle.Truncate(currentPiece.MovableFigure.GetBounds());

                            if (Math.Abs(currentPiece.PictureLocation.X - adjacentPiece.PictureLocation.X) <= 2)
                            {
                                int figureYDifferenceSign = Math.Sign(currentPieceMovableFigureEndLocation.Y - adjacentPieceMovableFigureEndLocation.Y);
                                int sourcePictureYDifferenceSign = Math.Sign(currentPiece.PictureLocation.Y - adjacentPiece.PictureLocation.Y);

                                if (figureYDifferenceSign != sourcePictureYDifferenceSign)
                                {
                                    continue;
                                }
                            }
                            else if (Math.Abs(currentPiece.PictureLocation.Y - adjacentPiece.PictureLocation.Y) <= 2)
                            {
                                int figureXDifferenceSign = Math.Sign(currentPieceMovableFigureEndLocation.X - adjacentPieceMovableFigureEndLocation.X);
                                int sourceImageXDifferenceSign = Math.Sign(currentPiece.PictureLocation.X - adjacentPiece.PictureLocation.X);

                                if (figureXDifferenceSign != sourceImageXDifferenceSign)
                                {
                                    continue;
                                }
                            }

                            GraphicsPath combinedMovableFigure = new GraphicsPath();
                            combinedMovableFigure.AddPath(adjacentPiece.MovableFigure, false);
                            combinedMovableFigure.AddPath(currentPiece.MovableFigure, false);

                            Rectangle combinedMovableFigureEndLocation = Rectangle.Truncate(combinedMovableFigure.GetBounds());

                            Rectangle combinedPictureLocation = Rectangle.Union(adjacentPiece.PictureLocation, currentPiece.PictureLocation);

                            if (Math.Abs(combinedMovableFigureEndLocation.Width - combinedPictureLocation.Width) <= GameSettings.SNAP_TOLERANCE &&
                                Math.Abs(combinedMovableFigureEndLocation.Height - combinedPictureLocation.Height) <= GameSettings.SNAP_TOLERANCE)
                            {
                                PieceCluster adjacentPieceCluster = GetPieceClusterByID(adjacentPiece.PieceID);

                                NextInPieceID.Add(adjacentPieceCluster.ID);

                                foreach (Piece piece in adjacentPieceCluster.Pieces)
                                {
                                    piece.PieceID = currentPiece.PieceID;
                                }
                            }
                        }
                    }
                }

                if (NextInPieceID.Count > 0)
                {
                    foreach (int PieceID in NextInPieceID)
                    {
                        PieceCluster adjacentCluster = GetPieceClusterByID(PieceID);

                        foreach (Piece piece in adjacentCluster.Pieces)
                        {
                            _currentCluster.Pieces.Add(piece);
                        }

                        RemovePieceGroupByID(PieceID);
                    }
                    GraphicsPath combinedStaticFigure = new GraphicsPath();
                    Rectangle combinedEndLocation = _currentCluster.EndLocation;
                    Rectangle combinedPictureLocation = _currentCluster.PictureLocation;

                    foreach (Piece piece in _currentCluster.Pieces)
                    {
                        combinedStaticFigure.AddPath(piece.StaticFigure, false);
                        combinedEndLocation = Rectangle.Union(combinedEndLocation, piece.EndLocation);
                        combinedPictureLocation = Rectangle.Union(combinedPictureLocation, piece.PictureLocation);
                    }

                    _currentCluster.EndLocation = new Rectangle(combinedEndLocation.X, combinedEndLocation.Y,
                                                                        combinedPictureLocation.Width,
                                                                        combinedPictureLocation.Height);

                    _currentCluster.PictureLocation = combinedPictureLocation;
                    _currentCluster.Width = combinedPictureLocation.Width;
                    _currentCluster.Height = combinedPictureLocation.Height;
                    _currentCluster.StaticFigure = (GraphicsPath)combinedStaticFigure.Clone();
                    _currentCluster.MovableFigure = (GraphicsPath)combinedStaticFigure.Clone();

                    Rectangle combinedStaticFigureLocation = Rectangle.Truncate(combinedStaticFigure.GetBounds());

                    matrix.Reset();
                    matrix.Translate(0 - combinedStaticFigureLocation.X, 0 - combinedStaticFigureLocation.Y);
                    _currentCluster.MovableFigure.Transform(matrix);

                    matrix.Reset();
                    matrix.Translate(combinedEndLocation.X, combinedEndLocation.Y);
                    _currentCluster.MovableFigure.Transform(matrix);

                    matrix.Reset();
                    matrix.Translate(0 - combinedStaticFigureLocation.X, 0 - combinedStaticFigureLocation.Y);
                    GraphicsPath translatedCombinedStaticFigure = (GraphicsPath)combinedStaticFigure.Clone();
                    translatedCombinedStaticFigure.Transform(matrix);

                    Bitmap clusterPicture = new Bitmap(combinedPictureLocation.Width, combinedPictureLocation.Height);

                    using (Graphics gfx = Graphics.FromImage(clusterPicture))
                    {
                        gfx.FillRectangle(Brushes.White, 0, 0, clusterPicture.Width, clusterPicture.Height);

                        gfx.ResetClip();
                        gfx.SetClip(translatedCombinedStaticFigure);
                        gfx.DrawImage(_sourcePicture, new Rectangle(0, 0, clusterPicture.Width, clusterPicture.Height),
                                combinedStaticFigureLocation, GraphicsUnit.Pixel);

                        if (GameSettings.DRAW_PIECE_OUTLINE)
                        {
                            Pen outlinePen = new Pen(Color.Black)
                            {
                                Width = GameSettings.PIECE_OUTLINE_WIDTH,
                                Alignment = PenAlignment.Inset
                            };

                            gfx.SmoothingMode = SmoothingMode.AntiAlias;
                            gfx.DrawPath(outlinePen, translatedCombinedStaticFigure);
                        }
                    }

                    Bitmap modifiedClusterPicture = (Bitmap)clusterPicture.Clone();
                    ImageUtilities.EdgeDetectHorizontal(modifiedClusterPicture);
                    ImageUtilities.EdgeDetectVertical(modifiedClusterPicture);
                    clusterPicture = ImageUtilities.AlphaBlendMatrix(modifiedClusterPicture, clusterPicture, 200);

                    _currentCluster.Picture = (Bitmap)clusterPicture.Clone();

                    foreach (Piece piece in _currentCluster.Pieces)
                    {
                        int offsetX = piece.PictureLocation.X - combinedPictureLocation.X;
                        int offsetY = piece.PictureLocation.Y - combinedPictureLocation.Y;

                        int newLocationX = combinedEndLocation.X + offsetX;
                        int newLocationY = combinedEndLocation.Y + offsetY;

                        piece.EndLocation = new Rectangle(newLocationX, newLocationY, piece.Width, piece.Height);

                        Rectangle movableFigureEndLocation = Rectangle.Truncate(piece.MovableFigure.GetBounds());

                        matrix.Reset();
                        matrix.Translate(0 - movableFigureEndLocation.X, 0 - movableFigureEndLocation.Y);
                        piece.MovableFigure.Transform(matrix);

                        matrix.Reset();
                        matrix.Translate(newLocationX, newLocationY);
                        piece.MovableFigure.Transform(matrix);
                    }

                    Rectangle areaToClear = new Rectangle(combinedEndLocation.X, combinedEndLocation.Y,
                                                            combinedEndLocation.Width + GameSettings.DROP_SHADOW_DEPTH,
                                                            combinedEndLocation.Height + GameSettings.DROP_SHADOW_DEPTH);

                    using (Graphics gfx = Graphics.FromImage(_backBuffer))
                    {
                        gfx.DrawImage(_background, areaToClear, areaToClear, GraphicsUnit.Pixel);
                         

                        Region regionToRedraw = new Region(areaToClear);

                        foreach (PieceCluster cluster in _clusters)
                        {
                            Region clusterRegion = new Region(cluster.MovableFigure);
                            clusterRegion.Intersect(regionToRedraw);

                            if (!clusterRegion.IsEmpty(gfx))
                            {
                                gfx.SetClip(clusterRegion, CombineMode.Replace);
                                gfx.DrawImageUnscaled(cluster.Picture, cluster.EndLocation);
                            }
                        }
                    }
                    using (Graphics gfx = Graphics.FromImage(_board))
                    {
                        gfx.DrawImageUnscaled(_backBuffer, 0, 0);
                    }

                    using (Graphics gfx = this.CreateGraphics())
                    {
                        gfx.DrawImageUnscaled(_backBuffer, 0, 0);
                    }
                }
                _canMovePiece = false;
                _currentCluster = null;

                if (_clusters.Count == 1)
                {
                    if (_victoryAnnounced == false)
                    {
                        _victoryAnnounced = true;

                        common.GameComplete = true;
                        common.EndGame(panel3, btnBack, "Puzzle", "Time: " + lblTime.Text, "", System.Drawing.Color.YellowGreen);
                        btnDefault.Visible = true;
                        timer1.Stop();
                    }
                }
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            if (common.GameStarted)
                common.EndGame(null,null, null, null, null, System.Drawing.Color.YellowGreen);
            this.Close();
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        { 
            DialogResult result = openFileDialog1.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    if (_sourcePicture != null)
                    {
                        _sourcePicture.Dispose();
                    }
                    common.StartGame(panel3, btnBack);
                    btnDefault.Visible = false;
                    _sourcePicture = new Bitmap(openFileDialog1.FileName);
                    timer1.Start();
                    if (_sourcePicture.Width > _puzzlePictureWidth || _sourcePicture.Height > _puzzlePictureHeight)
                    {
                        _sourcePicture = ImageUtilities.ResizeImage(_sourcePicture, _puzzlePictureWidth, _puzzlePictureHeight, false);
                    }

                    ResponseMessage responseMsg = CreateCognitive_Stimulation();

                    if (!responseMsg.OK)
                    {
                        _sourcePicture.Dispose();
                        MessageBox.Show(responseMsg.Message);
                        return;
                    }

                    DisplayCognitive_Stimulation(Settings.Default.ShowImageHint);
                    _victoryAnnounced = false;
                }
            }
        }
        private ResponseMessage CreateCognitive_Stimulation()
        {
            if (_sourcePicture == null)
            {
                return new ResponseMessage
                {
                    Message = "Please provide source picture."
                };
            }

            int pieceWidth = _sourcePicture.Width / GameSettings.NUM_COLUMNS;
            int pieceHeight = _sourcePicture.Height / GameSettings.NUM_ROWS;

            if (pieceWidth < GameSettings.MIN_PIECE_WIDTH || pieceHeight < GameSettings.MIN_PIECE_HEIGHT)
            {
                return new ResponseMessage
                {
                    Message = "The picture is too small. Please select a bigger picture."
                };
            }

            int lastColPieceWidth = pieceWidth + (_sourcePicture.Width % GameSettings.NUM_COLUMNS);
            int lastRowPieceHeight = pieceHeight + (_sourcePicture.Height % GameSettings.NUM_ROWS);

            int lastRow = (GameSettings.NUM_ROWS - 1);
            int lastCol = (GameSettings.NUM_COLUMNS - 1);

            bool topCurveFlipVertical = false;
            bool bottomCurveFlipVertical = true;
            bool leftCurveFlipHorizontal = false;
            bool rightCurveFlipHorizontal = true;

            _currentCluster = null;
            _clusters = new List<PieceCluster>();

            Matrix matrix = new Matrix();

            Pen outlinePen = new Pen(Color.Black)
            {
                Width = GameSettings.PIECE_OUTLINE_WIDTH,
                Alignment = PenAlignment.Inset
            };

            int pieceID = 0;

            for (int row = 0; row < GameSettings.NUM_ROWS; row++)
            {
                for (int col = 0; col < GameSettings.NUM_COLUMNS; col++)
                {
                    GraphicsPath figure = new GraphicsPath();

                    int offsetX = (col * pieceWidth);
                    int offsetY = (row * pieceHeight);
                     
                    if (row == 0)
                    {
                        int startX = offsetX;
                        int startY = offsetY;
                        int endX = offsetX + (col == lastCol ? lastColPieceWidth : pieceWidth); ;
                        int endY = offsetY;

                        figure.AddLine(startX, startY, endX, endY);
                    }
                    else
                    {
                        int horizontalCurveLength = (col == lastCol ? lastColPieceWidth : pieceWidth);
                        Curve topCurve = Curve.CreateHorizontal(horizontalCurveLength);

                        if (topCurveFlipVertical)
                        {
                            topCurve.FlipVertical();
                        }

                        topCurve.Translate(offsetX, offsetY);
                        figure.AddBeziers(topCurve.Points);
                    }

                    if (col == lastCol)
                    {
                        int startX = offsetX + lastColPieceWidth;
                        int startY = offsetY;
                        int endX = offsetX + lastColPieceWidth;
                        int endY = offsetY + (row == lastRow ? lastRowPieceHeight : pieceHeight);

                        figure.AddLine(startX, startY, endX, endY);
                    }
                    else
                    {
                        int verticalCurveLength = (row == lastRow ? lastRowPieceHeight : pieceHeight);

                        Curve verticalCurve = Curve.CreateVertical(verticalCurveLength);

                        if (rightCurveFlipHorizontal)
                        {
                            verticalCurve.FlipHorizontal();
                        }

                        verticalCurve.Translate(offsetX + pieceWidth, offsetY);
                        figure.AddBeziers(verticalCurve.Points);
                    }


                    if (row == lastRow)
                    {
                        int startX = offsetX;
                        int startY = offsetY + lastRowPieceHeight;
                        int endX = offsetX + (col == lastCol ? lastColPieceWidth : pieceWidth);
                        int endY = offsetY + lastRowPieceHeight;

                        figure.AddLine(endX, endY, startX, startY);
                    }
                    else
                    {
                        int horizontalCurveLength = (col == lastCol ? lastColPieceWidth : pieceWidth);
                        Curve bottomCurve = Curve.CreateHorizontal(horizontalCurveLength);
                        bottomCurve.FlipHorizontal();

                        if (bottomCurveFlipVertical)
                        {
                            bottomCurve.FlipVertical();
                        }

                        bottomCurve.Translate(offsetX + horizontalCurveLength, offsetY + pieceHeight);
                        figure.AddBeziers(bottomCurve.Points);
                    }
                    if (col == 0)
                    {
                        int startX = offsetX;
                        int startY = offsetY;
                        int endX = offsetX;
                        int endY = offsetY + (row == lastRow ? lastRowPieceHeight : pieceHeight);

                        figure.AddLine(endX, endY, startX, startY);
                    }
                    else
                    {
                        int verticalCurveLength = (row == lastRow ? lastRowPieceHeight : pieceHeight);
                        Curve verticalCurve = Curve.CreateVertical(verticalCurveLength);
                        verticalCurve.FlipVertical();

                        if (leftCurveFlipHorizontal)
                        {
                            verticalCurve.FlipHorizontal();
                        }

                        verticalCurve.Translate(offsetX, offsetY + verticalCurveLength);
                        figure.AddBeziers(verticalCurve.Points);
                    }
                    List<Coordinate> adjacentCoords = new List<Coordinate>
                    {
                        new Coordinate(col, row - 1),
                        new Coordinate(col + 1, row),
                        new Coordinate(col, row + 1),
                        new Coordinate(col - 1, row)
                    };

                    List<int> NextInPieceID = DetermineNextInPieceID(adjacentCoords, GameSettings.NUM_COLUMNS);

                    Rectangle figureLocation = Rectangle.Truncate(figure.GetBounds());
                    matrix.Reset();
                    matrix.Translate(0 - figureLocation.X, 0 - figureLocation.Y);
                    GraphicsPath translatedFigure = (GraphicsPath)figure.Clone();
                    translatedFigure.Transform(matrix);

                    Rectangle translatedFigureLocation = Rectangle.Truncate(translatedFigure.GetBounds());

                    Bitmap piecePicture = new Bitmap(figureLocation.Width, figureLocation.Height);

                    using (Graphics gfx = Graphics.FromImage(piecePicture))
                    {
                        gfx.FillRectangle(Brushes.White, 0, 0, piecePicture.Width, piecePicture.Height);
                        gfx.ResetClip();
                        gfx.SetClip(translatedFigure);
                        gfx.DrawImage(_sourcePicture, new Rectangle(0, 0, piecePicture.Width, piecePicture.Height),
                                figureLocation, GraphicsUnit.Pixel);

                        if (GameSettings.DRAW_PIECE_OUTLINE)
                        {
                            gfx.SmoothingMode = SmoothingMode.AntiAlias;
                            gfx.DrawPath(outlinePen, translatedFigure);
                        }
                    }

                    Bitmap modifiedPiecePicture = (Bitmap)piecePicture.Clone();
                    ImageUtilities.EdgeDetectHorizontal(modifiedPiecePicture);
                    ImageUtilities.EdgeDetectVertical(modifiedPiecePicture);
                    piecePicture = ImageUtilities.AlphaBlendMatrix(modifiedPiecePicture, piecePicture, 200);

                    Piece piece = new Piece
                    {
                        ID = pieceID,
                        PieceID = pieceID,
                        Width = figureLocation.Width,
                        Height = figureLocation.Height,
                        EndLocation = translatedFigureLocation,
                        PictureLocation = figureLocation,
                        MovableFigure = (GraphicsPath)translatedFigure.Clone(),
                        StaticFigure = (GraphicsPath)figure.Clone(),
                        Picture = (Bitmap)piecePicture.Clone(),
                        NextInPieceID = NextInPieceID
                    };

                    PieceCluster cluster = new PieceCluster
                    {
                        ID = pieceID,
                        Width = figureLocation.Width,
                        Height = figureLocation.Height,
                        EndLocation = translatedFigureLocation,
                        PictureLocation = figureLocation,
                        //PictureLocation = new Rectangle(figureLocation.X, figureLocation.Y, figureLocation.Width, figureLocation.Height),
                        MovableFigure = (GraphicsPath)translatedFigure.Clone(),
                        StaticFigure = (GraphicsPath)figure.Clone(),
                        Picture = (Bitmap)piecePicture.Clone(),
                        Pieces = new List<Piece> { piece }
                    };

                    _clusters.Add(cluster);

                    topCurveFlipVertical = !topCurveFlipVertical;
                    bottomCurveFlipVertical = !bottomCurveFlipVertical;
                    leftCurveFlipHorizontal = !leftCurveFlipHorizontal;
                    rightCurveFlipHorizontal = !rightCurveFlipHorizontal;

                    pieceID++;
                }
            }

            Random random = new Random();

            int boardWidth = this.ClientSize.Width;
            int boardHeight = this.ClientSize.Height;

            foreach (PieceCluster cluster in _clusters)
            {
                int locationX = random.Next((panel2.Width + 400) + 1, boardWidth);
                int locationY = random.Next(((panel1.Height) + 1), boardHeight);
                 
                if ((locationX + cluster.Width) > boardWidth)
                {
                    locationX = locationX - ((locationX + cluster.Width) - boardWidth);
                }

                if ((locationY + cluster.Height) > boardHeight)
                {
                    locationY = locationY - ((locationY + cluster.Height) - boardHeight);
                }

                for (int index = 0; index < cluster.Pieces.Count; index++)
                {
                    Piece piece = cluster.Pieces[index];
                    piece.EndLocation = new Rectangle(locationX, locationY, piece.Width, piece.Height);

                    matrix.Reset();
                    matrix.Translate(locationX, locationY);
                    piece.MovableFigure.Transform(matrix);
                }

                cluster.EndLocation = new Rectangle(locationX, locationY, cluster.Width, cluster.Height);

                matrix.Reset();
                matrix.Translate(locationX, locationY);
                cluster.MovableFigure.Transform(matrix);
            }

            return new ResponseMessage
            {
                OK = true
            };
        }

        private ResponseMessage DisplayCognitive_Stimulation(bool showGhostPicture)
        {
            if (_sourcePicture == null)
            {
                return new ResponseMessage
                {
                    Message = "Please provide source picture."
                };
            }

            int boardWidth = this.ClientSize.Width;
            int boardHeight = this.ClientSize.Height;
            _puzzlePictureWidth = this.ClientSize.Width - panel2.Width - 300 - 100;
            _puzzlePictureHeight = this.ClientSize.Height - panel1.Height;
            _board = new Bitmap(boardWidth, boardHeight);
            _backBuffer = new Bitmap(boardWidth, boardHeight);
            _background = new Bitmap(boardWidth, boardHeight);

            using (Graphics gfx = Graphics.FromImage(_background))
            {
                SolidBrush colorBrush = new SolidBrush(Color.WhiteSmoke);

                gfx.FillRectangle(colorBrush,0, 0, _background.Width, _background.Height);
            }
            if (showGhostPicture)
            {
                _background = ImageUtilities.AlphaBlendMatrix(_background, _sourcePicture, GameSettings.GHOST_PICTURE_ALPHA);
            }

            using (Graphics gfx = Graphics.FromImage(_board))
            {
                gfx.DrawImageUnscaled(_background, 0, 0);

                foreach (PieceCluster cluster in _clusters)
                {
                    gfx.ResetClip();
                    gfx.SetClip(cluster.MovableFigure);
                    gfx.DrawImage(cluster.Picture, cluster.EndLocation);
                }
            }

            using (Graphics gfx = Graphics.FromImage(_backBuffer))
            {
                gfx.DrawImageUnscaled(_board, 0, 0);
            }

            using (Graphics gfx = this.CreateGraphics())
            {
                gfx.DrawImageUnscaled(_board, 0, 0);
            }

            return new ResponseMessage
            {
                OK = true
            };
        }

        private List<int> DetermineNextInPieceID(List<Coordinate> coords, int numColumns)
        {
            List<int> pieceIDs = new List<int>();

            foreach (Coordinate coord in coords)
            {
                if (coord.Y >= 0 && coord.Y < GameSettings.NUM_ROWS)
                {
                    if (coord.X >= 0 && coord.X < GameSettings.NUM_COLUMNS)
                    {
                        int pieceID = (coord.Y * numColumns) + coord.X;
                        pieceIDs.Add(pieceID);
                    }
                }
            }

            return pieceIDs;
        }
         
        private void timer1_Tick(object sender, EventArgs e)
        {
            int min, sec;
            usedtime++;

            min = usedtime / 600;
            sec = (usedtime - min * 600) / 10;
            var time = min + ":" + sec.ToString("00");

            lblTime.Text = time;
            if (common.GameStarted)
                Procedure.UpdateTimeGame(Session.UserGameID, time, 0, 0);
        }

        private void btnBestScore_Click(object sender, EventArgs e)
        {
            lblBestScore.Text = Procedure.GetBestScore().ToString();
        }

        private void btnBestScore_MouseEnter(object sender, EventArgs e)
        {
            lblBestScore.Text = Procedure.GetBestScore().ToString();
            lblBestScore.Visible = true;
        }

        private void btnBestScore_MouseHover(object sender, EventArgs e)
        {
            lblBestScore.Text = Procedure.GetBestScore().ToString();
            lblBestScore.Visible = true;
        }

        private void btnBestScore_MouseLeave(object sender, EventArgs e)
        {
            lblBestScore.Text = "";
            lblBestScore.Visible = false;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {

        }

        private Piece GetPieceByID(int pieceID)
        {
            foreach (PieceCluster cluster in _clusters)
            {
                foreach (Piece piece in cluster.Pieces)
                {
                    if (piece.ID == pieceID)
                    {
                        return piece;
                    }
                }
            }

            return null;
        }

        private PieceCluster GetPieceClusterByID(int groupID)
        {
            foreach (PieceCluster group in _clusters)
            {
                if (group.ID == groupID)
                {
                    return group;
                }
            }

            return null;
        }

        private bool RemovePieceGroupByID(int groupID)
        {
            for (int i = 0; i < _clusters.Count; i++)
            {
                if (_clusters[i].ID == groupID)
                {
                    _clusters.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
    }
}