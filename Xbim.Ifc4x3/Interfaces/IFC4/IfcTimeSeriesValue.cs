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
namespace Xbim.Ifc4x3.DateTimeResource
{
	public partial class @IfcTimeSeriesValue : IIfcTimeSeriesValue
	{

		[CrossSchemaAttribute(typeof(IIfcTimeSeriesValue), 1)]
		IItemSet<IIfcValue> IIfcTimeSeriesValue.ListValues 
		{ 
			get
			{
			
				return _listValuesIfc4 ?? (_listValuesIfc4 = new Common.Collections.ExtendedItemSet<MeasureResource.IfcValue, IIfcValue>(
                    ListValues, 
                    new ItemSet<IIfcValue>(this, 0, -1), 
                    v => v.ToIfc4(), 
                    v => v.ToIfc3()));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcValue> _listValuesIfc4;
	//## Custom code
	//##
	}
}