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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	public partial class @IfcFurnitureType : IIfcFurnitureType
	{

		[CrossSchemaAttribute(typeof(IIfcFurnitureType), 10)]
		Ifc4.Interfaces.IfcAssemblyPlaceEnum IIfcFurnitureType.AssemblyPlace 
		{ 
			get
			{
				//## Custom code to handle enumeration of AssemblyPlace
				//##
				switch (AssemblyPlace)
				{
					case ProductExtension.IfcAssemblyPlaceEnum.SITE:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.SITE;
					case ProductExtension.IfcAssemblyPlaceEnum.FACTORY:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.FACTORY;
					case ProductExtension.IfcAssemblyPlaceEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcAssemblyPlaceEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of AssemblyPlace
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcAssemblyPlaceEnum.SITE:
						AssemblyPlace = ProductExtension.IfcAssemblyPlaceEnum.SITE;
						return;
					case Ifc4.Interfaces.IfcAssemblyPlaceEnum.FACTORY:
						AssemblyPlace = ProductExtension.IfcAssemblyPlaceEnum.FACTORY;
						return;
					case Ifc4.Interfaces.IfcAssemblyPlaceEnum.NOTDEFINED:
						AssemblyPlace = ProductExtension.IfcAssemblyPlaceEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		private  Ifc4.Interfaces.IfcFurnitureTypeEnum? _predefinedType;


		[CrossSchemaAttribute(typeof(IIfcFurnitureType), 11)]
		Ifc4.Interfaces.IfcFurnitureTypeEnum? IIfcFurnitureType.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", -11);
				
			}
		}
	//## Custom code
	//##
	}
}