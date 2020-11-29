using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinGlobalizeSample.Resources;

namespace XamarinGlobalizeSample
{
	/// <summary>
	/// TranslateのXAMLマークアップ拡張により、リソース文字列を取得する
	/// </summary>
	[ContentProperty("Key")]  // Keyを規定のプロパティに指定 
	public class TranslateExtension : IMarkupExtension
	{
		/// <summary>
		/// リソース文字列のプロパティ名として利用する文字列
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// IMarkupExtension インタフェースとしてのマークアップ拡張処理
		/// </summary>
		/// <param name="serviceProvider"></param>
		/// <returns></returns>
		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (string.IsNullOrEmpty(Key))
			{
				return "Key is Null or Empty";
			}

			// Keyプロパティに指定されたキーをもとにリソースから文字列を取得
			return AppResources.ResourceManager.GetString(Key, AppResources.Culture) ?? Key;
		}
	}
}
