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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcRelAssociatesMaterial : IIfcRelAssociatesMaterial
	{
		Ifc4.MaterialResource.IfcMaterialSelect IIfcRelAssociatesMaterial.RelatingMaterial 
		{ 
			get
			{
				if (RelatingMaterial == null) return null;
				var ifcmaterial = RelatingMaterial as MaterialResource.IfcMaterial;
				if (ifcmaterial != null) 
					//## Handle entity IfcMaterial which is not a part of the target select interface Ifc4.MaterialResource.IfcMaterialSelect in property RelatingMaterial
                    return ifcmaterial;
					//##
				var ifcmateriallist = RelatingMaterial as MaterialResource.IfcMaterialList;
				if (ifcmateriallist != null) 
					return ifcmateriallist;
				var ifcmateriallayersetusage = RelatingMaterial as MaterialResource.IfcMaterialLayerSetUsage;
				if (ifcmateriallayersetusage != null) 
					//## Handle entity IfcMaterialLayerSetUsage which is not a part of the target select interface Ifc4.MaterialResource.IfcMaterialSelect in property RelatingMaterial
                    return ifcmateriallayersetusage;
					//##
				var ifcmateriallayerset = RelatingMaterial as MaterialResource.IfcMaterialLayerSet;
				if (ifcmateriallayerset != null) 
					//## Handle entity IfcMaterialLayerSet which is not a part of the target select interface Ifc4.MaterialResource.IfcMaterialSelect in property RelatingMaterial
                    return ifcmateriallayerset;
					//##
				var ifcmateriallayer = RelatingMaterial as MaterialResource.IfcMaterialLayer;
				if (ifcmateriallayer != null) 
					//## Handle entity IfcMaterialLayer which is not a part of the target select interface Ifc4.MaterialResource.IfcMaterialSelect in property RelatingMaterial
                    return ifcmateriallayer;
					//##
				return null;
			} 
		}

	//## Custom code
	//##
	}
}