//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.5.1+406576ddfa7f3577d959a32ec2296bd9f730786e
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "navigation"
	/// <summary>Navigation</summary>
	public partial interface INavigation : IPublishedContent
	{
		/// <summary>Add to Nav</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.1+406576ddfa7f3577d959a32ec2296bd9f730786e")]
		bool AddToNav { get; }
	}

	/// <summary>Navigation</summary>
	[PublishedModel("navigation")]
	public partial class Navigation : PublishedContentModel, INavigation
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.1+406576ddfa7f3577d959a32ec2296bd9f730786e")]
		public new const string ModelTypeAlias = "navigation";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.1+406576ddfa7f3577d959a32ec2296bd9f730786e")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.1+406576ddfa7f3577d959a32ec2296bd9f730786e")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.1+406576ddfa7f3577d959a32ec2296bd9f730786e")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Navigation, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Navigation(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Add to Nav: true ? visible : hide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.1+406576ddfa7f3577d959a32ec2296bd9f730786e")]
		[ImplementPropertyType("addToNav")]
		public virtual bool AddToNav => GetAddToNav(this, _publishedValueFallback);

		/// <summary>Static getter for Add to Nav</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.1+406576ddfa7f3577d959a32ec2296bd9f730786e")]
		public static bool GetAddToNav(INavigation that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "addToNav");
	}
}
