using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvent.Dal.Models
{
    public enum QuestionType
    {
        SingleLineTextBox, // will render a textbox 
        MultiLineTextBox, // will render a text area
        YesOrNo, //will render a checkbox
        SingleSelect, //will render a dropdownlist
        MultiSelect //will render a listbox
    }
    class Question
    {
        public int Id { get; set; }

        public string title { get; set; }

        public string Options { get; set; }

        public QuestionType QuestionType { get; set; }
    }
}
