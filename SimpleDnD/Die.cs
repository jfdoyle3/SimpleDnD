using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDnD
{
    class Die
    {
        public int Faces;
        public int FaceUp;
       
        public Die(int faces)
        {
            Random cast = new Random();
            this.Faces= faces;
            this.FaceUp = cast.Next(1, faces); 
        }

        public Die(int faces, int faceUp)
        {
            this.Faces = faces;
            this.FaceUp = faceUp;
        }
        private bool isValid()
        {
            this.Faces = 0;
            return true;
        }
    }
}
