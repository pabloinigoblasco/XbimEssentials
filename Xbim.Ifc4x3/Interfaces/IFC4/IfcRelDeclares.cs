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
namespace Xbim.Ifc4x3.Kernel
{
	public partial class @IfcRelDeclares : IIfcRelDeclares
	{

		[CrossSchemaAttribute(typeof(IIfcRelDeclares), 5)]
		IIfcContext IIfcRelDeclares.RelatingContext 
		{ 
			get
			{
				return RelatingContext;
			} 
			set
			{
				RelatingContext = value as IfcContext;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelDeclares), 6)]
		IItemSet<IIfcDefinitionSelect> IIfcRelDeclares.RelatedDefinitions 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcDefinitionSelect, IIfcDefinitionSelect>(RelatedDefinitions);
			} 
		}
	//## Custom code
	//##
	}
}