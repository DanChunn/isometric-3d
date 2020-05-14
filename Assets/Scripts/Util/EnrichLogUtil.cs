using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EnrichLogUtil
{
    static int logging_font_size = 24;
    public static string Colorize(string text, Color color){
        string size_tag_open = $"<size={logging_font_size}>";
        string size_tag_close = $"</size>";
    
        string color_hex = ColorUtility.ToHtmlStringRGB(color);
        string color_tag_open = $"<color=#{color_hex}>";
        string color_tag_close = $"</color>";

        string new_text = size_tag_open + color_tag_open + text + color_tag_close + size_tag_close;
        return new_text;
    }

}
