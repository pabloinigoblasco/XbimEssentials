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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcCovering : IIfcCovering
	{

		[CrossSchemaAttribute(typeof(IIfcCovering), 9)]
		Ifc4.Interfaces.IfcCoveringTypeEnum? IIfcCovering.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCoveringTypeEnum.CEILING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.CEILING;
					case IfcCoveringTypeEnum.FLOORING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.FLOORING;
					case IfcCoveringTypeEnum.CLADDING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.CLADDING;
					case IfcCoveringTypeEnum.ROOFING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.ROOFING;
					case IfcCoveringTypeEnum.INSULATION:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.INSULATION;
					case IfcCoveringTypeEnum.MEMBRANE:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.MEMBRANE;
					case IfcCoveringTypeEnum.SLEEVING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.SLEEVING;
					case IfcCoveringTypeEnum.WRAPPING:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.WRAPPING;
					case IfcCoveringTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
                        if (ObjectType.HasValue)
                        {
                            Ifc4.Interfaces.IfcCoveringTypeEnum result;
                            if (System.Enum.TryParse(ObjectType.Value, false, out result))
                                return result;
                        }
						//##
						return Ifc4.Interfaces.IfcCoveringTypeEnum.USERDEFINED;
					case IfcCoveringTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCoveringTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcCoveringTypeEnum.CEILING:
						PredefinedType = IfcCoveringTypeEnum.CEILING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.FLOORING:
						PredefinedType = IfcCoveringTypeEnum.FLOORING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.CLADDING:
						PredefinedType = IfcCoveringTypeEnum.CLADDING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.ROOFING:
						PredefinedType = IfcCoveringTypeEnum.ROOFING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.MOLDING:
						//## Handle setting of MOLDING member from IfcCoveringTypeEnum in property PredefinedType
						ObjectType = value.ToString();
                        PredefinedType = IfcCoveringTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcCoveringTypeEnum.SKIRTINGBOARD:
						//## Handle setting of SKIRTINGBOARD member from IfcCoveringTypeEnum in property PredefinedType
						ObjectType = value.ToString();
                        PredefinedType = IfcCoveringTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcCoveringTypeEnum.INSULATION:
						PredefinedType = IfcCoveringTypeEnum.INSULATION;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.MEMBRANE:
						PredefinedType = IfcCoveringTypeEnum.MEMBRANE;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.SLEEVING:
						PredefinedType = IfcCoveringTypeEnum.SLEEVING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.WRAPPING:
						PredefinedType = IfcCoveringTypeEnum.WRAPPING;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.USERDEFINED:
						PredefinedType = IfcCoveringTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCoveringTypeEnum.NOTDEFINED:
						PredefinedType = IfcCoveringTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		IEnumerable<IIfcRelCoversSpaces> IIfcCovering.CoversSpaces 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelCoversSpaces>(e => e.RelatedCoverings != null &&  e.RelatedCoverings.Contains(this), "RelatedCoverings", this);
			} 
		}
		IEnumerable<IIfcRelCoversBldgElements> IIfcCovering.CoversElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelCoversBldgElements>(e => e.RelatedCoverings != null &&  e.RelatedCoverings.Contains(this), "RelatedCoverings", this);
			} 
		}
	//## Custom code
	//##
	}
}