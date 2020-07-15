/**
 * Copyright (c) 2017 The Campfire Union Inc - All Rights Reserved.
 *
 * Licensed under the MIT license. See LICENSE file in the project root for
 * full license information.
 *
 * Email:   info@campfireunion.com
 * Website: https://www.campfireunion.com
 */

namespace VRKeys {

	/// <summary>
	/// Base class for keyboard layouts to inherit from in order to support
	/// additional languages.
	///
	/// See the VRKeys/Scripts/Layouts folder for example layouts.
	/// To add a translation, you will need to register it in the Layouts.cs
	/// class too.
	/// </summary>
	public class Layout {
		public string placeholderMessage = "Натисни кнопку щоб почати писати...";

		public string spaceButtonLabel = "Пробіл";

		public string enterButtonLabel = "Ентр";

		public string cancelButtonLabel = "Кенсл";

		public string shiftButtonLabel = "Шифт";

		public string backspaceButtonLabel = "Бекспейс";

		public string clearButtonLabel = "Очистити";
		

		public string[] row1Keys = { "'", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};

		public string[] row1Shift = { "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+" };

		public string[] row2Keys = { "й", "ц", "у", "к", "е", "н", "г", "ш", "щ", "з", "х", "ї"};

		public string[] row2Shift = { "Й", "Ц", "У", "К", "Е", "Н", "Г", "Ш", "Щ", "З", "Х", "Ї"};

		public string[] row3Keys = { "ф", "і", "в", "а", "п", "р", "о", "л", "д", "ж", "є" };

		public string[] row3Shift = { "Ф", "І", "В", "А", "П", "Р", "О", "Л", "Д", "ж", "Є" };

		public string[] row4Keys = { "я", "ч", "с", "м", "и", "т", "ь", "б", "ю"};

		public string[] row4Shift = { "Я", "Ч", "С", "М", "И", "Т", "Ь", "б", "Ю"};

		public float row1Offset = 0.16f;

		public float row2Offset = 0.08f;

		public float row3Offset = 0f;

		public float row4Offset = -0.08f;

		/// <summary>
		/// Get the total number of keys in all four rows.
		/// </summary>
		public int TotalKeys () {
			return row1Keys.Length + row2Keys.Length + row3Keys.Length + row4Keys.Length;
		}
	}
}