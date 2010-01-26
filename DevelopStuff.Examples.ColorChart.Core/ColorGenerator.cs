using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;

namespace DevelopStuff.Examples.ColorChart.Core
{
    public class ColorGenerator
    {

        #region Fields

        private static ColorGenerator _instance;
        private List<Color> _colors = new List<Color>();

        [ThreadStatic]
        private static readonly object _padlock = new object();

        #endregion

        #region Constructor

        private ColorGenerator()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// The core instance of <see cref="ColorGenerator"/>
        /// </summary>
        public static ColorGenerator Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ColorGenerator();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Gets the colors.
        /// </summary>
        public List<Color> Colors
        {
            get
            {
                if ((this._colors == null) || (this._colors.Count < 1))
                {
                    Color keystoneColor = Color.AliceBlue;
                    Type colorType = keystoneColor.GetType();

                    if (null != colorType)
                    {
                        PropertyInfo[] properties = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);

                        foreach (PropertyInfo property in properties)
                        {
                            Color color = (Color)property.GetValue(null, null);
                            _colors.Add(color);
                        }
                    }
                }

                return this._colors;
            }
        }

        #endregion

    }
}
