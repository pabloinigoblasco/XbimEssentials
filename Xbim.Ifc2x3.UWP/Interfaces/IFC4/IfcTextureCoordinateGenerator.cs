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
namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	public partial class @IfcTextureCoordinateGenerator : IIfcTextureCoordinateGenerator
	{

		[CrossSchemaAttribute(typeof(IIfcTextureCoordinateGenerator), 2)]
		Ifc4.MeasureResource.IfcLabel IIfcTextureCoordinateGenerator.Mode 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Mode);
			} 
			set
			{
				Mode = new MeasureResource.IfcLabel(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTextureCoordinateGenerator), 3)]
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcReal> IIfcTextureCoordinateGenerator.Parameter 
		{ 
			get
			{
				//## Handle return of Parameter for which no match was found
                foreach (var param in this.Parameter)
                {
                    if (param.UnderlyingSystemType == typeof(double) || param.UnderlyingSystemType == typeof(int))
                        yield return new Xbim.Ifc4.MeasureResource.IfcReal(System.Convert.ToDouble(param.Value));
                    else if (param.UnderlyingSystemType == typeof(string))
                    {
                        double ret;
                        if (double.TryParse((string)param.Value, out ret))
                            yield return new Xbim.Ifc4.MeasureResource.IfcReal(ret);
                    }
                }
				//##
			} 
		}
	//## Custom code
	//##
	}
}