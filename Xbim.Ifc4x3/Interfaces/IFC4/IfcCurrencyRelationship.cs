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
namespace Xbim.Ifc4x3.CostResource
{
	public partial class @IfcCurrencyRelationship : IIfcCurrencyRelationship
	{

		[CrossSchemaAttribute(typeof(IIfcCurrencyRelationship), 3)]
		IIfcMonetaryUnit IIfcCurrencyRelationship.RelatingMonetaryUnit 
		{ 
			get
			{
				return RelatingMonetaryUnit;
			} 
			set
			{
				RelatingMonetaryUnit = value as MeasureResource.IfcMonetaryUnit;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCurrencyRelationship), 4)]
		IIfcMonetaryUnit IIfcCurrencyRelationship.RelatedMonetaryUnit 
		{ 
			get
			{
				return RelatedMonetaryUnit;
			} 
			set
			{
				RelatedMonetaryUnit = value as MeasureResource.IfcMonetaryUnit;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCurrencyRelationship), 5)]
		Ifc4.MeasureResource.IfcPositiveRatioMeasure IIfcCurrencyRelationship.ExchangeRate 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveRatioMeasure(ExchangeRate);
			} 
			set
			{
				ExchangeRate = new MeasureResource.IfcPositiveRatioMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCurrencyRelationship), 6)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcCurrencyRelationship.RateDateTime 
		{ 
			get
			{
				if (!RateDateTime.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDateTime(RateDateTime.Value);
			} 
			set
			{
				RateDateTime = value.HasValue ? 
					new DateTimeResource.IfcDateTime(value.Value) :  
					 new DateTimeResource.IfcDateTime?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCurrencyRelationship), 7)]
		IIfcLibraryInformation IIfcCurrencyRelationship.RateSource 
		{ 
			get
			{
				return RateSource;
			} 
			set
			{
				RateSource = value as ExternalReferenceResource.IfcLibraryInformation;
				
			}
		}
	//## Custom code
	//##
	}
}