﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("productCatalog", Namespace="", IsNullable=true)]
public partial class ProductCatalog {
    
    private string catalogNameField;
    
    private System.DateTime expiryDateField;
    
    private Product[] productsField;
    
    /// <remarks/>
    public string catalogName {
        get {
            return this.catalogNameField;
        }
        set {
            this.catalogNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime expiryDate {
        get {
            return this.expiryDateField;
        }
        set {
            this.expiryDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("product")]
    public Product[] products {
        get {
            return this.productsField;
        }
        set {
            this.productsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Product {
    
    private string productNameField;
    
    private decimal productPriceField;
    
    private bool inStockField;
    
    private string idField;
    
    /// <remarks/>
    public string productName {
        get {
            return this.productNameField;
        }
        set {
            this.productNameField = value;
        }
    }
    
    /// <remarks/>
    public decimal productPrice {
        get {
            return this.productPriceField;
        }
        set {
            this.productPriceField = value;
        }
    }
    
    /// <remarks/>
    public bool inStock {
        get {
            return this.inStockField;
        }
        set {
            this.inStockField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}
