﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
#if EF6
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.EntityClient;
#else
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
#endif

[assembly: EdmSchema()]
namespace MySql.Data.Entity.Tests
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class datesTypesEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new datesTypesEntities object using the connection string found in the 'datesTypesEntities' section of the application configuration file.
        /// </summary>
        public datesTypesEntities() : base("name=datesTypesEntities", "datesTypesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new datesTypesEntities object.
        /// </summary>
        public datesTypesEntities(string connectionString) : base(connectionString, "datesTypesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new datesTypesEntities object.
        /// </summary>
        public datesTypesEntities(EntityConnection connection) : base(connection, "datesTypesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<product> products
        {
            get
            {
                if ((_products == null))
                {
                    _products = base.CreateObjectSet<product>("products");
                }
                return _products;
            }
        }
        private ObjectSet<product> _products;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToproducts(product product)
        {
            base.AddObject("products", product);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="test_datestypesModel", Name="product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new product object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="dateCreated">Initial value of the DateCreated property.</param>
        /// <param name="timestamp">Initial value of the Timestamp property.</param>
        /// <param name="dateTimeWithPrecision">Initial value of the DateTimeWithPrecision property.</param>
        /// <param name="timeStampWithPrecision">Initial value of the TimeStampWithPrecision property.</param>
        public static product Createproduct(global::System.Int32 id, global::System.DateTime dateCreated, global::System.DateTime timestamp, global::System.DateTime dateTimeWithPrecision, global::System.DateTime timeStampWithPrecision)
        {
            product product = new product();
            product.Id = id;
            product.DateCreated = dateCreated;
            product.Timestamp = timestamp;
            product.DateTimeWithPrecision = dateTimeWithPrecision;
            product.TimeStampWithPrecision = timeStampWithPrecision;
            return product;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateCreated
        {
            get
            {
                return _DateCreated;
            }
            set
            {
                OnDateCreatedChanging(value);
                ReportPropertyChanging("DateCreated");
                _DateCreated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateCreated");
                OnDateCreatedChanged();
            }
        }
        private global::System.DateTime _DateCreated;
        partial void OnDateCreatedChanging(global::System.DateTime value);
        partial void OnDateCreatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Timestamp
        {
            get
            {
                return _Timestamp;
            }
            set
            {
                OnTimestampChanging(value);
                ReportPropertyChanging("Timestamp");
                _Timestamp = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Timestamp");
                OnTimestampChanged();
            }
        }
        private global::System.DateTime _Timestamp;
        partial void OnTimestampChanging(global::System.DateTime value);
        partial void OnTimestampChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateTimeWithPrecision
        {
            get
            {
                return _DateTimeWithPrecision;
            }
            set
            {
                OnDateTimeWithPrecisionChanging(value);
                ReportPropertyChanging("DateTimeWithPrecision");
                _DateTimeWithPrecision = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateTimeWithPrecision");
                OnDateTimeWithPrecisionChanged();
            }
        }
        private global::System.DateTime _DateTimeWithPrecision;
        partial void OnDateTimeWithPrecisionChanging(global::System.DateTime value);
        partial void OnDateTimeWithPrecisionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime TimeStampWithPrecision
        {
            get
            {
                return _TimeStampWithPrecision;
            }
            set
            {
                OnTimeStampWithPrecisionChanging(value);
                ReportPropertyChanging("TimeStampWithPrecision");
                _TimeStampWithPrecision = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TimeStampWithPrecision");
                OnTimeStampWithPrecisionChanged();
            }
        }
        private global::System.DateTime _TimeStampWithPrecision;
        partial void OnTimeStampWithPrecisionChanging(global::System.DateTime value);
        partial void OnTimeStampWithPrecisionChanged();

        #endregion

    
    }

    #endregion

    
}
