using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphicsLaba2
{
    class Coordinates3D
    {
        private float x;
        private float y;
        private float z;
        
        public Coordinates3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public float X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public float Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public float Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

    }
}
