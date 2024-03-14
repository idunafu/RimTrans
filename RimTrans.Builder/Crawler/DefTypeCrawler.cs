﻿using System;
using System.Linq;
using System.Text;

namespace RimTrans.Builder.Crawler
{
    /// <summary>
    /// Get all DefTypes for coding the source file 'DefTypeNameOf.cs'.
    /// </summary>
    public static class DefTypeCrawler {
        /// <summary>
        /// Get partial source code or only names.
        /// </summary>
        /// <param name="formating"></param>
        /// <param name="sorting"></param>
        public static string GenCode(bool formating, bool sorting) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(formating ?
                "        public static readonly string Def = \"Def\";" :
                "Def");
            var allSubDefTypes = sorting ?
                Helper.ClassDef.AllSubclasses().OrderBy(t => t.Name).ToList() :
                Helper.ClassDef.AllSubclasses();
            foreach (Type curDefType in allSubDefTypes) {
                sb.AppendLine(formating ?
                    $"        public static readonly string {curDefType.Name} = \"{curDefType.Name}\";" :
                    curDefType.Name);
            }
            return sb.ToString();
        }
    }
}
