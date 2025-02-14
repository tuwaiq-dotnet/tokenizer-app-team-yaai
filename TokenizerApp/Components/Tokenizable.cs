﻿/*
 * Tuwaiq .NET Bootcamp
 * 
 * Authors
 * 
 *  Younes Alturkey
 *  Abdulrahman Bin Maneea
 *  Abdullah Albagshi
 *  Ibrahim Alobaysi
 */

namespace TokenizerApp
{
	public abstract class Tokenizable
	{
		public abstract bool tokenizable(Tokenizer tokenizer);
		public abstract Token tokenize(Tokenizer tokenizer);

		/*
		 * loop
		 */
	}
}
