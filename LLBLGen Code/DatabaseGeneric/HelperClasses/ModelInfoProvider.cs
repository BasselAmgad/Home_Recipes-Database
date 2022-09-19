﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using HomeRecipesCode.FactoryClasses;
using HomeRecipesCode.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace HomeRecipesCode.HelperClasses
{
	/// <summary>Singleton implementation of the ModelInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	public static class ModelInfoProviderSingleton
	{
		private static readonly IModelInfoProvider _providerInstance = new ModelInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static ModelInfoProviderSingleton()	{ }

		/// <summary>Gets the singleton instance of the ModelInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IModelInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the ModelInfoProvider.</summary>
	internal class ModelInfoProviderCore : ModelInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="ModelInfoProviderCore"/> class.</summary>
		internal ModelInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitCategoryEntityInfo();
			InitRecipeEntityInfo();
			InitRecipeCategoryEntityInfo();
			InitUserEntityInfo();
			this.BuildInternalStructures();
		}

		/// <summary>Inits CategoryEntity's info objects</summary>
		private void InitCategoryEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(CategoryFieldIndex), "CategoryEntity");
			this.AddElementFieldInfo("CategoryEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)CategoryFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("CategoryEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)CategoryFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("CategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)CategoryFieldIndex.Name, 30, 0, 0);
		}

		/// <summary>Inits RecipeEntity's info objects</summary>
		private void InitRecipeEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(RecipeFieldIndex), "RecipeEntity");
			this.AddElementFieldInfo("RecipeEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)RecipeFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("RecipeEntity", "Ingredients", typeof(System.String), false, false, false, false,  (int)RecipeFieldIndex.Ingredients, 255, 0, 0);
			this.AddElementFieldInfo("RecipeEntity", "Instructions", typeof(System.String), false, false, false, false,  (int)RecipeFieldIndex.Instructions, 255, 0, 0);
			this.AddElementFieldInfo("RecipeEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)RecipeFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("RecipeEntity", "Title", typeof(System.String), false, false, false, false,  (int)RecipeFieldIndex.Title, 255, 0, 0);
		}

		/// <summary>Inits RecipeCategoryEntity's info objects</summary>
		private void InitRecipeCategoryEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(RecipeCategoryFieldIndex), "RecipeCategoryEntity");
			this.AddElementFieldInfo("RecipeCategoryEntity", "CategoryId", typeof(System.Guid), false, true, false, false,  (int)RecipeCategoryFieldIndex.CategoryId, 0, 0, 0);
			this.AddElementFieldInfo("RecipeCategoryEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)RecipeCategoryFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("RecipeCategoryEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)RecipeCategoryFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("RecipeCategoryEntity", "RecipeId", typeof(System.Guid), false, true, false, false,  (int)RecipeCategoryFieldIndex.RecipeId, 0, 0, 0);
		}

		/// <summary>Inits UserEntity's info objects</summary>
		private void InitUserEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "Id", typeof(System.Guid), true, false, false, false,  (int)UserFieldIndex.Id, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)UserFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 255, 0, 0);
			this.AddElementFieldInfo("UserEntity", "RefreshToken", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.RefreshToken, 255, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Username", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Username, 255, 0, 0);
		}
	}
}