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
	public partial class @IfcIndexedTextureMap : IIfcIndexedTextureMap
	{

		[CrossSchemaAttribute(typeof(IIfcIndexedTextureMap), 2)]
		IIfcTessellatedFaceSet IIfcIndexedTextureMap.MappedTo 
		{ 
			get
			{
				return MappedTo;
			} 
			set
			{
				MappedTo = value as GeometricModelResource.IfcTessellatedFaceSet;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcIndexedTextureMap), 3)]
		IIfcTextureVertexList IIfcIndexedTextureMap.TexCoords 
		{ 
			get
			{
				return TexCoords;
			} 
			set
			{
				TexCoords = value as IfcTextureVertexList;
				
			}
		}
	//## Custom code
	//##
	}
}