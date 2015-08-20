using System;

namespace BoolExplore2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[] {22,12,34};

			Console.Write("Въведете индекс: ");
			int _ui = 0;
			string _input = "0";
			_input=Console.ReadLine();

			bool _check01 = int.TryParse( _input, out _ui );

			try 
			{
				Console.Write("Елемент с номер "+_ui.ToString()+" е ");
				Console.WriteLine(_i[_ui-1]);
			}catch{
				Console.WriteLine(" < недефиниран елемент >" );		
			}

			// Оператор switch
//			switch (_ui) {
//			case 1:
//				{
//					Console.Write ("1ви елемент от масива: ");
//					Console.WriteLine (_i [_ui - 1]);
//					break;
//				}
//			case 2:
//				{
//					Console.Write ("2ри елемент от масива: ");
//					Console.WriteLine (_i [_ui - 1]);
//					break;
//				}
//			case 3:
//				{
//					Console.Write ("1ти елемент от масива: ");
//					Console.WriteLine (_i [_ui - 1]);
//					break;
//				}
//			default :{
//					Console.WriteLine ("В масива няма елемент с този индекс.\n\n\nОпитайте с индекс между 1 и " 
//							+ Convert.ToString( _i.Length ) + "\n\n");
//					break;
//				}

			}

		}
	
}
