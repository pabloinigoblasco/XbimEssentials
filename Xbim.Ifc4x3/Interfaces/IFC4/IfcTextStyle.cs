// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	public partial class @IfcTextStyle : IIfcTextStyle
	{

		[CrossSchemaAttribute(typeof(IIfcTextStyle), 2)]
		IIfcTextStyleForDefinedFont IIfcTextStyle.TextCharacterAppearance 
		{ 
			get
			{
				return TextCharacterAppearance;
			} 
			set
			{
				TextCharacterAppearance = value as IfcTextStyleForDefinedFont;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTextStyle), 3)]
		IIfcTextStyleTextModel IIfcTextStyle.TextStyle 
		{ 
			get
			{
				return TextStyle;
			} 
			set
			{
				TextStyle = value as IfcTextStyleTextModel;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTextStyle), 4)]
		IIfcTextFontSelect IIfcTextStyle.TextFontStyle 
		{ 
			get
			{
				if (TextFontStyle == null) return null;
				var ifcexternallydefinedtextfont = TextFontStyle as IfcExternallyDefinedTextFont;
				if (ifcexternallydefinedtextfont != null) 
					return ifcexternallydefinedtextfont;
				var ifcpredefinedtextfont = TextFontStyle as IfcPreDefinedTextFont;
				if (ifcpredefinedtextfont != null) 
					return ifcpredefinedtextfont;
				return null;
			} 
			set
			{
				if (value == null)
				{
					TextFontStyle = null;
					return;
				}	
				var ifcexternallydefinedtextfont = value as IfcExternallyDefinedTextFont;
				if (ifcexternallydefinedtextfont != null) 
				{
					TextFontStyle = ifcexternallydefinedtextfont;
					return;
				}
				var ifcpredefinedtextfont = value as IfcPreDefinedTextFont;
				if (ifcpredefinedtextfont != null) 
				{
					TextFontStyle = ifcpredefinedtextfont;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTextStyle), 5)]
		Ifc4.MeasureResource.IfcBoolean? IIfcTextStyle.ModelOrDraughting 
		{ 
			get
			{
				if (!ModelOrDraughting.HasValue) return null;
				return new Ifc4.MeasureResource.IfcBoolean(ModelOrDraughting.Value);
			} 
			set
			{
				ModelOrDraughting = value.HasValue ? 
					new MeasureResource.IfcBoolean(value.Value) :  
					 new MeasureResource.IfcBoolean?() ;
				
			}
		}
	//## Custom code
	//##
	}
}