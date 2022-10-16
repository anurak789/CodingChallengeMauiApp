using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingChallengeMauiApp.Models
{
    public class OldPhone
    {
        public string OldPhonePad(string input)
        {
            string result = string.Empty;
            string letter = string.Empty;
            try
            {
                input = Regex.Replace(input, @"(?<=(.))(?!\1)(?=.)", " ");
                var items = Regex.Split(input, @"(?<=([1-9]))(?=[1-9])(?!\1)|(?<=\s)(?=[1-9])(?!\1)");

                foreach (string i in items)
                {
                    switch (i)
                    {
                        case var keyVal when new Regex(@"^\b([1])\b").IsMatch(keyVal):
                            letter = "&";
                            break;
                        case var keyVal when new Regex(@"^\b([1][1])\b").IsMatch(keyVal):
                            letter = "'";
                            break;
                        case var keyVal when new Regex(@"^\b([1][1][1])\b").IsMatch(keyVal):
                            letter = "(";
                            break;
                        case var keyVal when new Regex(@"^\b([2])\b").IsMatch(keyVal):
                            letter = "A";
                            break;
                        case var keyVal when new Regex(@"^\b([2][2])\b").IsMatch(keyVal):
                            letter = "B";
                            break;
                        case var keyVal when new Regex(@"^\b([2][2][2])\b").IsMatch(keyVal):
                            letter = "C";
                            break;
                        case var keyVal when new Regex(@"^\b([3])\b").IsMatch(keyVal):
                            letter = "D";
                            break;
                        case var keyVal when new Regex(@"^\b([3][3])\b").IsMatch(keyVal):
                            letter = "E";
                            break;
                        case var keyVal when new Regex(@"^\b([3][3][3])\b").IsMatch(keyVal):
                            letter = "F";
                            break;
                        case var keyVal when new Regex(@"^\b([4])\b").IsMatch(keyVal):
                            letter = "G";
                            break;
                        case var keyVal when new Regex(@"^\b([4][4])\b").IsMatch(keyVal):
                            letter = "H";
                            break;
                        case var keyVal when new Regex(@"^\b([4][4][4])\b").IsMatch(keyVal):
                            letter = "I";
                            break;
                        case var keyVal when new Regex(@"^\b([5])\b").IsMatch(keyVal):
                            letter = "J";
                            break;
                        case var keyVal when new Regex(@"^\b([5][5])\b").IsMatch(keyVal):
                            letter = "K";
                            break;
                        case var keyVal when new Regex(@"^\b([5][5][5])\b").IsMatch(keyVal):
                            letter = "L";
                            break;
                        case var keyVal when new Regex(@"^\b([6])\b").IsMatch(keyVal):
                            letter = "M";
                            break;
                        case var keyVal when new Regex(@"^\b([6][6])\b").IsMatch(keyVal):
                            letter = "N";
                            break;
                        case var keyVal when new Regex(@"^\b([6][6][6])\b").IsMatch(keyVal):
                            letter = "O";
                            break;
                        case var keyVal when new Regex(@"^\b([7])\b").IsMatch(keyVal):
                            letter = "P";
                            break;
                        case var keyVal when new Regex(@"^\b([7][7])\b").IsMatch(keyVal):
                            letter = "Q";
                            break;
                        case var keyVal when new Regex(@"^\b([7][7][7])\b").IsMatch(keyVal):
                            letter = "R";
                            break;
                        case var keyVal when new Regex(@"^\b([7][7][7][7])\b").IsMatch(keyVal):
                            letter = "S";
                            break;
                        case var keyVal when new Regex(@"^\b([8])\b").IsMatch(keyVal):
                            letter = "T";
                            break;
                        case var keyVal when new Regex(@"^\b([8][8])\b").IsMatch(keyVal):
                            letter = "U";
                            break;
                        case var keyVal when new Regex(@"^\b([8][8][8])\b").IsMatch(keyVal):
                            letter = "V";
                            break;
                        case var keyVal when new Regex(@"^\b([9])\b").IsMatch(keyVal):
                            letter = "W";
                            break;
                        case var keyVal when new Regex(@"^\b([9][9])\b").IsMatch(keyVal):
                            letter = "X";
                            break;
                        case var keyVal when new Regex(@"^\b([9][9][9])\b").IsMatch(keyVal):
                            letter = "Y";
                            break;
                        case var keyVal when new Regex(@"^\b([9][9][9][9])\b").IsMatch(keyVal):
                            letter = "Z";
                            break;
                        default:
                            letter = input;
                            break;
                    }
                    result += letter;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
