// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.ActorResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ConstraintResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMetric
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMetric : IIfcConstraint
	{
		IfcBenchmarkEnum @Benchmark { get; }
		IfcLabel? @ValueSource { get; }
		IfcMetricValueSelect @DataValue { get; }
		
	}
}

namespace Xbim.Ifc2x3.ConstraintResource
{
	[ExpressType("IFCMETRIC", 80)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMetric : IfcConstraint, IInstantiableEntity, IIfcMetric, IEqualityComparer<@IfcMetric>, IEquatable<@IfcMetric>
	{
		#region IIfcMetric explicit implementation
		IfcBenchmarkEnum IIfcMetric.Benchmark { get { return @Benchmark; } }	
		IfcLabel? IIfcMetric.ValueSource { get { return @ValueSource; } }	
		IfcMetricValueSelect IIfcMetric.DataValue { get { return @DataValue; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMetric(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcBenchmarkEnum _benchmark;
		private IfcLabel? _valueSource;
		private IfcMetricValueSelect _dataValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcBenchmarkEnum @Benchmark 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _benchmark;
				((IPersistEntity)this).Activate(false);
				return _benchmark;
			} 
			set
			{
				SetValue( v =>  _benchmark = v, _benchmark, value,  "Benchmark");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ValueSource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _valueSource;
				((IPersistEntity)this).Activate(false);
				return _valueSource;
			} 
			set
			{
				SetValue( v =>  _valueSource = v, _valueSource, value,  "ValueSource");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMetricValueSelect @DataValue 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _dataValue;
				((IPersistEntity)this).Activate(false);
				return _dataValue;
			} 
			set
			{
				SetValue( v =>  _dataValue = v, _dataValue, value,  "DataValue");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
                    _benchmark = (IfcBenchmarkEnum) System.Enum.Parse(typeof (IfcBenchmarkEnum), value.EnumVal, true);
					return;
				case 8: 
					_valueSource = value.StringVal;
					return;
				case 9: 
					_dataValue = (IfcMetricValueSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMetric other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMetric
            var root = (@IfcMetric)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMetric left, @IfcMetric right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMetric left, @IfcMetric right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMetric x, @IfcMetric y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMetric obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}