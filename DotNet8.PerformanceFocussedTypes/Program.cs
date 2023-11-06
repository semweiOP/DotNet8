using System.Buffers;
using System.Collections.Frozen;


var configData = new Dictionary<string, bool>()
{
    {"setting1", true },
    {"setting2", false}
};

var frozenConfigData = configData.ToFrozenDictionary(/*optimizeForRead: true*/);



var listData = Enumerable.Range(0, 1000);

var frozenListData = listData.ToFrozenSet();


char[] chars = { 'a', 'e', 'i', 'o', 'u', 'y',
                       'A', 'E', 'I', 'O', 'U', 'Y' };

var searchValues = SearchValues.Create( chars );

String s = "The long and winding road...";

Console.WriteLine("The first vowel in \n   {0}\nis found at position {1}",
                  s, s.IndexOfAny(chars) + 1);