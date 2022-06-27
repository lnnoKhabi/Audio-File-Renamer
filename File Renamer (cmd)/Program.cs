using System;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace File_Renamer__cmd_
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine(" ENTER 'Q' TO QUIT! ");
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine();

			while ( true ) 
			{ 
				Console.Write("Specify folder location: ");
				Console.ForegroundColor = ConsoleColor.Yellow;
				string folder = Console.ReadLine();
				Console.ForegroundColor = ConsoleColor.White;
				

				if ( folder != "q" )
				{
					Console.Write("Auto detect repeated phrase (Yes/No): ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					string detect = Console.ReadLine();
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine();
					if (detect.ToLower() == "yes")
					{
						string[] fileNames = Directory.GetFiles(folder);
						//string extension = fileNames[0].Substring(fileNames[0].IndexOf('.'));
						getFiles(fileNames);
						string possiblePhrase = ""; 
						string s = fileNames[0];
						//detect repeated text by cutting from left then/or right 
						//just compare fisrt and second names in array
						for (int i = 0; i < fileNames[0].Length; i++)
						{
							//removing from right/end
							if (fileNames[1].Contains(s.Substring(0,s.Length - i)))
							{
								possiblePhrase = s.Substring(0, s.Length - i);
								break;
							}
							//removing from left/beginning
							else if (fileNames[1].Contains(s.Substring(i)))
							{
								possiblePhrase = s.Substring(i);
								break;
							}
							
						}
						if (!string.IsNullOrEmpty(possiblePhrase))
						{
							Console.Write($"\tRemove");
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.Write($" \"{possiblePhrase}\"");
							Console.ForegroundColor = ConsoleColor.White;
							Console.Write($" (Yes/No): ");
							Console.ForegroundColor = ConsoleColor.Yellow;
							string ans = Console.ReadLine();
							Console.ForegroundColor = ConsoleColor.White;
							Console.WriteLine();
							if (ans.ToLower() == "yes")
							{
								string actual_file = "";

								foreach (string file in Directory.GetFiles(folder))
								{
									actual_file = file.Substring(file.LastIndexOf('\\') + 1);
									if (file.Contains(possiblePhrase, StringComparison.CurrentCultureIgnoreCase))
									{
										//renaming the file names
										FileSystem.RenameFile(file, file.Substring(file.LastIndexOf('\\') + 1).Replace(possiblePhrase, "", true, CultureInfo.CurrentCulture));
										Console.Write(actual_file);
										Console.ForegroundColor = ConsoleColor.Green;
										Console.Write(" ...file renamed successfully");

										


										Console.ForegroundColor = ConsoleColor.White;
										Console.WriteLine();
									}
									else
									{
										Console.Write(actual_file);
										Console.ForegroundColor = ConsoleColor.Red;
										Console.Write($" does not contain \"{possiblePhrase}\"");
										Console.ForegroundColor = ConsoleColor.White;
										Console.WriteLine();
									}
								}
							}
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine("No repeated phrase detected");
							Console.ForegroundColor = ConsoleColor.White;
						}

					}
					else if (detect.ToLower() == "no")
					{


						Console.Write("Specify phrase to remove: ");
						Console.ForegroundColor = ConsoleColor.Yellow;
						string phrase = Console.ReadLine();
						Console.ForegroundColor = ConsoleColor.White;


						if (!string.IsNullOrEmpty(folder) && !string.IsNullOrEmpty(phrase))
						{
							try
							{
								Console.WriteLine();
								//string actual_file = "";

								//Console.ForegroundColor = ConsoleColor.Yellow;
								//Console.Write("Edit file's: \n\t1.name ");
								//Console.WriteLine();
								//string edit = Console.ReadLine();
								//Console.ForegroundColor = ConsoleColor.White;

								//if (!string.IsNullOrEmpty(edit))//if edit accepted
								//{
									foreach (string file in Directory.GetFiles(folder))
									{
										EditFile(file, "1", phrase);
									}
								//}
								//else
								//{
								//	throw new Exception("Invalid selection!");
								//}
							}
							catch (Exception error)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine(error.Message);
								Console.ForegroundColor = ConsoleColor.White;
								Console.WriteLine();
							}
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine("You did not specify a valid folder and/or phrase");
							Console.ForegroundColor = ConsoleColor.White;
						}
					}
				}
				else
				{
					break;
				}
				Console.WriteLine();
			}
		}

		public static void getFiles(string[] names)
		{
			//List<string> res = new List<string>(names.Length) ;
			for (int i = 0; i < names.Length; i++)
			{
				int textIndex = names[i].LastIndexOf('\\');
				names[i] = names[i].Substring(textIndex + 1, names[i].LastIndexOf('.') - (textIndex + 1));
			}
		}

		public static void EditFile(string file, string edit, string phrase)
		{
			//edit file's name
			if (edit == "1")
			{
				string actual_file = file.Substring(file.LastIndexOf('\\') + 1);
				if (file.Contains(phrase, StringComparison.CurrentCultureIgnoreCase))
				{
					FileSystem.RenameFile(file, file.Substring(file.LastIndexOf('\\') + 1).Replace(phrase, "", true, CultureInfo.CurrentCulture));
					Console.Write(actual_file);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write(" ...name edited successfully");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine();
				}
				else
				{
					Console.Write(actual_file);
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write($" does not contain \"{phrase}\"");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine();
				}
			}

			//edit file's metadata [title, contributing artists]
			/*else if (edit == "2")
			{
				var audio_file = TagLib.File.Create(file);
				string title = audio_file.Tag.Title;
				string[] artists = audio_file.Tag.AlbumArtists;

				//title
				if (title.Contains(phrase, StringComparison.CurrentCultureIgnoreCase))
				{
					audio_file.Tag.Title = audio_file.Tag.Title.Substring(file.LastIndexOf('\\') + 1).Replace(phrase, "", true, CultureInfo.CurrentCulture);


					Console.Write(audio_file.Tag.Title);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write($" ...title successfully changed to {audio_file.Tag.Title }");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine();
				}
				else
				{
					Console.Write(audio_file.Tag.Title);
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write($" does not contain \"{phrase}\"");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine();
				}

				//artists
				if (artists.Length > 0)
				{
					foreach (var artist in artists)
					{
						audio_file.Tag.Performers = new string[] { artist.Replace(phrase, "", true, CultureInfo.CurrentCulture) };

						Console.Write(artist);
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write($" ...artist successfully changed to {audio_file.Tag.Performers[0] }");
						Console.ForegroundColor = ConsoleColor.White;
						Console.WriteLine();
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write($" no artists found \"{phrase}\"");
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine();
				}
				audio_file.Save();

			}

			else if(edit == "3")
			{
				EditFile(file, "1", phrase);
				EditFile(file, "2", phrase);
			}
			*/
		}
	}
}
