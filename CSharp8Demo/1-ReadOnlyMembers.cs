using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Demo
{
   public struct Rectangle
    {
        public double Length { get; set; }
        public double Height { get; set; }
        
        
        // FULL PROPERTY will result in implicit copy in the readonly method
        //private int _height;

        //public int Height
        //{
        //    get { return _height; }
        //    set { _height = value; }
        //}

        public readonly double Area()
        {
            return Length * Height;
            //Height += 1;  // DOES NOT WORK AS THE METHOD IS READONLY
        }
    }
}
