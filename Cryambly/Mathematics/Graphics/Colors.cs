﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryCil.Graphics
{
	/// <summary>
	/// Defines static variables that represent known colors.
	/// </summary>
	public static class Colors
	{
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Transparent
			= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Transparent]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte AliceBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.AliceBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte AntiqueWhite
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.AntiqueWhite]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Aqua
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Aqua]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Aquamarine
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Aquamarine]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Azure
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Azure]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Beige
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Beige]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Bisque
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Bisque]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Black
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Black]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte BlanchedAlmond
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.BlanchedAlmond]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Blue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Blue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte BlueViolet
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.BlueViolet]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Brown
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Brown]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte BurlyWood
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.BurlyWood]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte CadetBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.CadetBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Chartreuse
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Chartreuse]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Chocolate
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Chocolate]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Coral
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Coral]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte CornflowerBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.CornflowerBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Cornsilk
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Cornsilk]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Crimson
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Crimson]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Cyan
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Cyan]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkCyan
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkCyan]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkGoldenrod
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkGoldenrod]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkGray
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkGray]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkKhaki
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkKhaki]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkMagenta
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkMagenta]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkOliveGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkOliveGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkOrange
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkOrange]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkOrchid
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkOrchid]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkRed
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkRed]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkSalmon
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkSalmon]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkSeaGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkSeaGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkSlateBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkSlateBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkSlateGray
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkSlateGray]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkTurquoise
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkTurquoise]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DarkViolet
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DarkViolet]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DeepPink
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DeepPink]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DeepSkyBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DeepSkyBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DimGray
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DimGray]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte DodgerBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.DodgerBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Firebrick
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Firebrick]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte FloralWhite
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.FloralWhite]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte ForestGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.ForestGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Fuchsia
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Fuchsia]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Gainsboro
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Gainsboro]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte GhostWhite
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.GhostWhite]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Gold
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Gold]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Goldenrod
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Goldenrod]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Gray
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Gray]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Green
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Green]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte GreenYellow
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.GreenYellow]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Honeydew
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Honeydew]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte HotPink
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.HotPink]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte IndianRed
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.IndianRed]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Indigo
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Indigo]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Ivory
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Ivory]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Khaki
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Khaki]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Lavender
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Lavender]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LavenderBlush
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LavenderBlush]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LawnGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LawnGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LemonChiffon
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LemonChiffon]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightCoral
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightCoral]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightCyan
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightCyan]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightGoldenrodYellow
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightGoldenrodYellow]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightGray
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightGray]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightPink
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightPink]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightSalmon
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightSalmon]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightSeaGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightSeaGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightSkyBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightSkyBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightSlateGray
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightSlateGray]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightSteelBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightSteelBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LightYellow
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LightYellow]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Lime
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Lime]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte LimeGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.LimeGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Linen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Linen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Magenta
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Magenta]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Maroon
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Maroon]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MediumAquamarine
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MediumAquamarine]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MediumBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MediumBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MediumOrchid
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MediumOrchid]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MediumPurple
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MediumPurple]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MediumSeaGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MediumSeaGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MediumSlateBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MediumSlateBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MediumSpringGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MediumSpringGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MediumTurquoise
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MediumTurquoise]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MediumVioletRed
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MediumVioletRed]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MidnightBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MidnightBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MintCream
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MintCream]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte MistyRose
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.MistyRose]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Moccasin
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Moccasin]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte NavajoWhite
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.NavajoWhite]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Navy
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Navy]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte OldLace
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.OldLace]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Olive
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Olive]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte OliveDrab
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.OliveDrab]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Orange
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Orange]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte OrangeRed
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.OrangeRed]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Orchid
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Orchid]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte PaleGoldenrod
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.PaleGoldenrod]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte PaleGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.PaleGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte PaleTurquoise
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.PaleTurquoise]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte PaleVioletRed
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.PaleVioletRed]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte PapayaWhip
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.PapayaWhip]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte PeachPuff
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.PeachPuff]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Peru
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Peru]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Pink
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Pink]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Plum
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Plum]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte PowderBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.PowderBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Purple
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Purple]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Red
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Red]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte RosyBrown
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.RosyBrown]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte RoyalBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.RoyalBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte SaddleBrown
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.SaddleBrown]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Salmon
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Salmon]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte SandyBrown
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.SandyBrown]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte SeaGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.SeaGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte SeaShell
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.SeaShell]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Sienna
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Sienna]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Silver
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Silver]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte SkyBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.SkyBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte SlateBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.SlateBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte SlateGray
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.SlateGray]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Snow
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Snow]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte SpringGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.SpringGreen]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte SteelBlue
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.SteelBlue]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Tan
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Tan]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Teal
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Teal]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Thistle
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Thistle]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Tomato
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Tomato]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Turquoise
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Turquoise]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Violet
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Violet]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Wheat
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Wheat]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte White
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.White]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte WhiteSmoke
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.WhiteSmoke]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte Yellow
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.Yellow]);
		/// <summary>
		/// A known color value.
		/// </summary>
		public static readonly ColorByte YellowGreen
					= new ColorByte(ColorValues.ArgbValues[(int)KnownColor.YellowGreen]);
	}
	internal class ColorValues
	{
		internal static uint[] ArgbValues =
		{
			0x00000000, /* 000 - Empty */
			0xFFD4D0C8, /* 001 - ActiveBorder */
			0xFF0054E3, /* 002 - ActiveCaption */
			0xFFFFFFFF, /* 003 - ActiveCaptionText */
			0xFF808080, /* 004 - AppWorkspace */
			0xFFECE9D8, /* 005 - Control */
			0xFFACA899, /* 006 - ControlDark */
			0xFF716F64, /* 007 - ControlDarkDark */
			0xFFF1EFE2, /* 008 - ControlLight */
			0xFFFFFFFF, /* 009 - ControlLightLight */
			0xFF000000, /* 010 - ControlText */
			0xFF004E98, /* 011 - Desktop */
			0xFFACA899, /* 012 - GrayText */
			0xFF316AC5, /* 013 - Highlight */
			0xFFFFFFFF, /* 014 - HighlightText */
			0xFF000080, /* 015 - HotTrack */
			0xFFD4D0C8, /* 016 - InactiveBorder */
			0xFF7A96DF, /* 017 - InactiveCaption */
			0xFFD8E4F8, /* 018 - InactiveCaptionText */
			0xFFFFFFE1, /* 019 - Info */
			0xFF000000, /* 020 - InfoText */
			0xFFFFFFFF, /* 021 - Menu */
			0xFF000000, /* 022 - MenuText */
			0xFFD4D0C8, /* 023 - ScrollBar */
			0xFFFFFFFF, /* 024 - Window */
			0xFF000000, /* 025 - WindowFrame */
			0xFF000000, /* 026 - WindowText */
			0x00FFFFFF, /* 027 - Transparent */
			0xFFF0F8FF, /* 028 - AliceBlue */
			0xFFFAEBD7, /* 029 - AntiqueWhite */
			0xFF00FFFF, /* 030 - Aqua */
			0xFF7FFFD4, /* 031 - Aquamarine */
			0xFFF0FFFF, /* 032 - Azure */
			0xFFF5F5DC, /* 033 - Beige */
			0xFFFFE4C4, /* 034 - Bisque */
			0xFF000000, /* 035 - Black */
			0xFFFFEBCD, /* 036 - BlanchedAlmond */
			0xFF0000FF, /* 037 - Blue */
			0xFF8A2BE2, /* 038 - BlueViolet */
			0xFFA52A2A, /* 039 - Brown */
			0xFFDEB887, /* 040 - BurlyWood */
			0xFF5F9EA0, /* 041 - CadetBlue */
			0xFF7FFF00, /* 042 - Chartreuse */
			0xFFD2691E, /* 043 - Chocolate */
			0xFFFF7F50, /* 044 - Coral */
			0xFF6495ED, /* 045 - CornflowerBlue */
			0xFFFFF8DC, /* 046 - Cornsilk */
			0xFFDC143C, /* 047 - Crimson */
			0xFF00FFFF, /* 048 - Cyan */
			0xFF00008B, /* 049 - DarkBlue */
			0xFF008B8B, /* 050 - DarkCyan */
			0xFFB8860B, /* 051 - DarkGoldenrod */
			0xFFA9A9A9, /* 052 - DarkGray */
			0xFF006400, /* 053 - DarkGreen */
			0xFFBDB76B, /* 054 - DarkKhaki */
			0xFF8B008B, /* 055 - DarkMagenta */
			0xFF556B2F, /* 056 - DarkOliveGreen */
			0xFFFF8C00, /* 057 - DarkOrange */
			0xFF9932CC, /* 058 - DarkOrchid */
			0xFF8B0000, /* 059 - DarkRed */
			0xFFE9967A, /* 060 - DarkSalmon */
			0xFF8FBC8B, /* 061 - DarkSeaGreen */
			0xFF483D8B, /* 062 - DarkSlateBlue */
			0xFF2F4F4F, /* 063 - DarkSlateGray */
			0xFF00CED1, /* 064 - DarkTurquoise */
			0xFF9400D3, /* 065 - DarkViolet */
			0xFFFF1493, /* 066 - DeepPink */
			0xFF00BFFF, /* 067 - DeepSkyBlue */
			0xFF696969, /* 068 - DimGray */
			0xFF1E90FF, /* 069 - DodgerBlue */
			0xFFB22222, /* 070 - Firebrick */
			0xFFFFFAF0, /* 071 - FloralWhite */
			0xFF228B22, /* 072 - ForestGreen */
			0xFFFF00FF, /* 073 - Fuchsia */
			0xFFDCDCDC, /* 074 - Gainsboro */
			0xFFF8F8FF, /* 075 - GhostWhite */
			0xFFFFD700, /* 076 - Gold */
			0xFFDAA520, /* 077 - Goldenrod */
			0xFF808080, /* 078 - Gray */
			0xFF008000, /* 079 - Green */
			0xFFADFF2F, /* 080 - GreenYellow */
			0xFFF0FFF0, /* 081 - Honeydew */
			0xFFFF69B4, /* 082 - HotPink */
			0xFFCD5C5C, /* 083 - IndianRed */
			0xFF4B0082, /* 084 - Indigo */
			0xFFFFFFF0, /* 085 - Ivory */
			0xFFF0E68C, /* 086 - Khaki */
			0xFFE6E6FA, /* 087 - Lavender */
			0xFFFFF0F5, /* 088 - LavenderBlush */
			0xFF7CFC00, /* 089 - LawnGreen */
			0xFFFFFACD, /* 090 - LemonChiffon */
			0xFFADD8E6, /* 091 - LightBlue */
			0xFFF08080, /* 092 - LightCoral */
			0xFFE0FFFF, /* 093 - LightCyan */
			0xFFFAFAD2, /* 094 - LightGoldenrodYellow */
			0xFFD3D3D3, /* 095 - LightGray */
			0xFF90EE90, /* 096 - LightGreen */
			0xFFFFB6C1, /* 097 - LightPink */
			0xFFFFA07A, /* 098 - LightSalmon */
			0xFF20B2AA, /* 099 - LightSeaGreen */
			0xFF87CEFA, /* 100 - LightSkyBlue */
			0xFF778899, /* 101 - LightSlateGray */
			0xFFB0C4DE, /* 102 - LightSteelBlue */
			0xFFFFFFE0, /* 103 - LightYellow */
			0xFF00FF00, /* 104 - Lime */
			0xFF32CD32, /* 105 - LimeGreen */
			0xFFFAF0E6, /* 106 - Linen */
			0xFFFF00FF, /* 107 - Magenta */
			0xFF800000, /* 108 - Maroon */
			0xFF66CDAA, /* 109 - MediumAquamarine */
			0xFF0000CD, /* 110 - MediumBlue */
			0xFFBA55D3, /* 111 - MediumOrchid */
			0xFF9370DB, /* 112 - MediumPurple */
			0xFF3CB371, /* 113 - MediumSeaGreen */
			0xFF7B68EE, /* 114 - MediumSlateBlue */
			0xFF00FA9A, /* 115 - MediumSpringGreen */
			0xFF48D1CC, /* 116 - MediumTurquoise */
			0xFFC71585, /* 117 - MediumVioletRed */
			0xFF191970, /* 118 - MidnightBlue */
			0xFFF5FFFA, /* 119 - MintCream */
			0xFFFFE4E1, /* 120 - MistyRose */
			0xFFFFE4B5, /* 121 - Moccasin */
			0xFFFFDEAD, /* 122 - NavajoWhite */
			0xFF000080, /* 123 - Navy */
			0xFFFDF5E6, /* 124 - OldLace */
			0xFF808000, /* 125 - Olive */
			0xFF6B8E23, /* 126 - OliveDrab */
			0xFFFFA500, /* 127 - Orange */
			0xFFFF4500, /* 128 - OrangeRed */
			0xFFDA70D6, /* 129 - Orchid */
			0xFFEEE8AA, /* 130 - PaleGoldenrod */
			0xFF98FB98, /* 131 - PaleGreen */
			0xFFAFEEEE, /* 132 - PaleTurquoise */
			0xFFDB7093, /* 133 - PaleVioletRed */
			0xFFFFEFD5, /* 134 - PapayaWhip */
			0xFFFFDAB9, /* 135 - PeachPuff */
			0xFFCD853F, /* 136 - Peru */
			0xFFFFC0CB, /* 137 - Pink */
			0xFFDDA0DD, /* 138 - Plum */
			0xFFB0E0E6, /* 139 - PowderBlue */
			0xFF800080, /* 140 - Purple */
			0xFFFF0000, /* 141 - Red */
			0xFFBC8F8F, /* 142 - RosyBrown */
			0xFF4169E1, /* 143 - RoyalBlue */
			0xFF8B4513, /* 144 - SaddleBrown */
			0xFFFA8072, /* 145 - Salmon */
			0xFFF4A460, /* 146 - SandyBrown */
			0xFF2E8B57, /* 147 - SeaGreen */
			0xFFFFF5EE, /* 148 - SeaShell */
			0xFFA0522D, /* 149 - Sienna */
			0xFFC0C0C0, /* 150 - Silver */
			0xFF87CEEB, /* 151 - SkyBlue */
			0xFF6A5ACD, /* 152 - SlateBlue */
			0xFF708090, /* 153 - SlateGray */
			0xFFFFFAFA, /* 154 - Snow */
			0xFF00FF7F, /* 155 - SpringGreen */
			0xFF4682B4, /* 156 - SteelBlue */
			0xFFD2B48C, /* 157 - Tan */
			0xFF008080, /* 158 - Teal */
			0xFFD8BFD8, /* 159 - Thistle */
			0xFFFF6347, /* 160 - Tomato */
			0xFF40E0D0, /* 161 - Turquoise */
			0xFFEE82EE, /* 162 - Violet */
			0xFFF5DEB3, /* 163 - Wheat */
			0xFFFFFFFF, /* 164 - White */
			0xFFF5F5F5, /* 165 - WhiteSmoke */
			0xFFFFFF00, /* 166 - Yellow */
			0xFF9ACD32  /* 167 - YellowGreen */
}
;
	}
}