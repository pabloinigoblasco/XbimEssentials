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
namespace Xbim.Ifc4x3.ActorResource
{
	public partial class @IfcTelecomAddress : IIfcTelecomAddress
	{

		[CrossSchemaAttribute(typeof(IIfcTelecomAddress), 4)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcLabel> IIfcTelecomAddress.TelephoneNumbers 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcLabel, Ifc4.MeasureResource.IfcLabel>(TelephoneNumbers, 
					s => new Ifc4.MeasureResource.IfcLabel(s), 
					t => new MeasureResource.IfcLabel(t));
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcTelecomAddress), 5)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcLabel> IIfcTelecomAddress.FacsimileNumbers 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcLabel, Ifc4.MeasureResource.IfcLabel>(FacsimileNumbers, 
					s => new Ifc4.MeasureResource.IfcLabel(s), 
					t => new MeasureResource.IfcLabel(t));
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcTelecomAddress), 6)]
		Ifc4.MeasureResource.IfcLabel? IIfcTelecomAddress.PagerNumber 
		{ 
			get
			{
				if (!PagerNumber.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(PagerNumber.Value);
			} 
			set
			{
				PagerNumber = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTelecomAddress), 7)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcLabel> IIfcTelecomAddress.ElectronicMailAddresses 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcLabel, Ifc4.MeasureResource.IfcLabel>(ElectronicMailAddresses, 
					s => new Ifc4.MeasureResource.IfcLabel(s), 
					t => new MeasureResource.IfcLabel(t));
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcTelecomAddress), 8)]
		Ifc4.ExternalReferenceResource.IfcURIReference? IIfcTelecomAddress.WWWHomePageURL 
		{ 
			get
			{
				if (!WWWHomePageURL.HasValue) return null;
				return new Ifc4.ExternalReferenceResource.IfcURIReference(WWWHomePageURL.Value);
			} 
			set
			{
				WWWHomePageURL = value.HasValue ? 
					new ExternalReferenceResource.IfcURIReference(value.Value) :  
					 new ExternalReferenceResource.IfcURIReference?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTelecomAddress), 9)]
		IItemSet<Xbim.Ifc4.ExternalReferenceResource.IfcURIReference> IIfcTelecomAddress.MessagingIDs 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<ExternalReferenceResource.IfcURIReference, Ifc4.ExternalReferenceResource.IfcURIReference>(MessagingIDs, 
					s => new Ifc4.ExternalReferenceResource.IfcURIReference(s), 
					t => new ExternalReferenceResource.IfcURIReference(t));
			} 
		}
	//## Custom code
	//##
	}
}