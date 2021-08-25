﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Cognitive_Stimulation
{ 
    public class Piece
    { 
        public int ID { get; set; } 
        public int PieceID { get; set; } 
        public List<int> NextInPieceID { get; set; } 
        public int Width { get; set; } 
        public int Height { get; set; } 
        public Rectangle EndLocation { get; set; } 
        public Rectangle PictureLocation { get; set; } 
        public GraphicsPath MovableFigure { get; set; } 
        public GraphicsPath StaticFigure { get; set; } 
        public Bitmap Picture { get; set; }                          
    }

    public class PieceCluster
    {
        public int ID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle EndLocation { get; set; }
        public Rectangle PictureLocation { get; set; }
        public GraphicsPath MovableFigure { get; set; }
        public GraphicsPath StaticFigure { get; set; }
        public Bitmap Picture { get; set; }
        public List<Piece> Pieces { get; set; }
    }
}
