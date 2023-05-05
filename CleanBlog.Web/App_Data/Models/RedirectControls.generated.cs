//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.18.7
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "redirectControls"
	/// <summary>Redirect Controls</summary>
	public partial interface IRedirectControls : IPublishedContent
	{
		/// <summary>Is Temporary Redirect</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.7")]
		bool IsTemporaryRedirect { get; }

		/// <summary>Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.7")]
		global::Umbraco.Web.Models.Link Link { get; }
	}

	/// <summary>Redirect Controls</summary>
	[PublishedModel("redirectControls")]
	public partial class RedirectControls : PublishedContentModel, IRedirectControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.7")]
		public new const string ModelTypeAlias = "redirectControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.7")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.7")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.7")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<RedirectControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public RedirectControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Is Temporary Redirect: Tick this if you want this redirect to only be temporary
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.7")]
		[ImplementPropertyType("isTemporaryRedirect")]
		public virtual bool IsTemporaryRedirect => GetIsTemporaryRedirect(this);

		/// <summary>Static getter for Is Temporary Redirect</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.7")]
		public static bool GetIsTemporaryRedirect(IRedirectControls that) => that.Value<bool>("isTemporaryRedirect");

		///<summary>
		/// Link: Enter the link for this redirect
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.7")]
		[ImplementPropertyType("link")]
		public virtual global::Umbraco.Web.Models.Link Link => GetLink(this);

		/// <summary>Static getter for Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.7")]
		public static global::Umbraco.Web.Models.Link GetLink(IRedirectControls that) => that.Value<global::Umbraco.Web.Models.Link>("link");
	}
}