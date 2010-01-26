using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DevelopStuff.Examples.ColorChart.Core
{
    public class ColorComparer : IComparer<Color>
    {

        #region Fields

        private ColorSort _sort;

        #endregion

        #region Constructor

        public ColorComparer(ColorSort sort)
        {
            this._sort = sort;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the color sort order.
        /// </summary>
        public ColorSort ColorSortOrder
        {
            get
            {
                return this._sort;
            }
        }

        #endregion

        #region IComparer<Color> Members

        /// <summary>
        /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>
        /// Value Condition Less than zerox is less than y.Zerox equals y.Greater than zerox is greater than y.
        /// </returns>
        public int Compare(Color x, Color y)
        {
            int leftColorValue;
            int rightColorValue;
            switch (this.ColorSortOrder)
            {
                case ColorSort.ByCluster:
                    if (x.GetHue() < y.GetHue()) return -1;
                    else if (x.GetHue() > y.GetHue()) return 1;
                    else
                    {
                        if (x.GetSaturation() < y.GetSaturation()) return -1;
                        else if (x.GetSaturation() > y.GetSaturation()) return 1;
                        else
                        {
                            if (x.GetBrightness() < y.GetBrightness()) return -1;
                            else if (x.GetBrightness() > y.GetBrightness()) return 1;
                            else return 0;
                        }
                    }
                case ColorSort.ByBlueValue:
                    leftColorValue = x.B;
                    rightColorValue = y.B;
                    break;
                case ColorSort.ByGreenValue:
                    leftColorValue = x.G;
                    rightColorValue = y.G;
                    break;
                case ColorSort.ByRedValue:
                    leftColorValue = x.R;
                    rightColorValue = y.R;
                    break;
                case ColorSort.ByName:
                default:
                    return x.Name.CompareTo(y.Name);
            }

            return rightColorValue.CompareTo(leftColorValue);
        }

        #endregion

    }
}
