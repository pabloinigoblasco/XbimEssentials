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
namespace Xbim.Ifc4x3.MaterialResource
{
	public partial class @IfcMaterialConstituentSet : IIfcMaterialConstituentSet
	{

		[CrossSchemaAttribute(typeof(IIfcMaterialConstituentSet), 1)]
		Ifc4.MeasureResource.IfcLabel? IIfcMaterialConstituentSet.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialConstituentSet), 2)]
		Ifc4.MeasureResource.IfcText? IIfcMaterialConstituentSet.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialConstituentSet), 3)]
		IItemSet<IIfcMaterialConstituent> IIfcMaterialConstituentSet.MaterialConstituents 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcMaterialConstituent, IIfcMaterialConstituent>(MaterialConstituents);
			} 
		}
	//## Custom code
	//##
	}
}