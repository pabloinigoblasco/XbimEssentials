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
namespace Xbim.Ifc4x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralConnection : IIfcStructuralConnection
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralConnection), 8)]
		IIfcBoundaryCondition IIfcStructuralConnection.AppliedCondition 
		{ 
			get
			{
				return AppliedCondition;
			} 
			set
			{
				AppliedCondition = value as StructuralLoadResource.IfcBoundaryCondition;
				
			}
		}
		IEnumerable<IIfcRelConnectsStructuralMember> IIfcStructuralConnection.ConnectsStructuralMembers 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelConnectsStructuralMember>(e => (e.RelatedStructuralConnection as IfcStructuralConnection) == this, "RelatedStructuralConnection", this);
			} 
		}
	//## Custom code
	//##
	}
}