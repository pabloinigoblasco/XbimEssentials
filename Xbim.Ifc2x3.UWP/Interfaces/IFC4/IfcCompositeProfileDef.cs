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
namespace Xbim.Ifc2x3.ProfileResource
{
	public partial class @IfcCompositeProfileDef : IIfcCompositeProfileDef
	{

		[CrossSchemaAttribute(typeof(IIfcCompositeProfileDef), 3)]
		IItemSet<IIfcProfileDef> IIfcCompositeProfileDef.Profiles 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcProfileDef, IIfcProfileDef>(Profiles);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcCompositeProfileDef), 4)]
		Ifc4.MeasureResource.IfcLabel? IIfcCompositeProfileDef.Label 
		{ 
			get
			{
				if (!Label.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Label.Value);
			} 
			set
			{
				Label = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}