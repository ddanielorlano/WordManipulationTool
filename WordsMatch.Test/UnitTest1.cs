using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace WordsMatch.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var word = "Daniel  Orlan";
            var split = word.Split(new char[0],StringSplitOptions.RemoveEmptyEntries);
        }
    //    [TestMethod]
    //    public void RemovePunctuationAndSortTest()
    //    {
    //        List<string> wordList = new List<string>
    //        {
    //            ".","Daniel","Orlan","Alphabet",")",
    //            "Contained","]","in","'","this","list",
    //            "?","zeb",">", "="
    //        };
    //        Model m = new Model();
    //       var result= m.RemovePunctuationAndSort(wordList);
    //    }
    //    [TestMethod]
    //    public void SplitTest()
    //    {
    //        string word = "('11', '22', '33')";
    //        // var result = word.Split(new char[] {'\'',',','(',')'}).Where(x=> !string.IsNullOrWhiteSpace(x));
    //        var result = word.Split(new char[] { '\'', ',', '(', ')' });
    //    }
    //    [TestMethod]
    //    public void ExtensionTest()
    //    {
    //        List<string> punctuationList = new List<string>
    //    {"'","\"","\\","/",",",".",">","<","=",">=","<=","]","[","(",")"};
    //        List<bool> isPunctList = new List<bool>();
    //        foreach(var letter in punctuationList)
    //        {
    //            isPunctList.Add(letter.IsPunct());
    //        }
    //        var boolCount = isPunctList.Where(x => x == true).Count();
    //        Assert.AreEqual(boolCount, punctuationList.Count());
    //    }
    }
  
}
