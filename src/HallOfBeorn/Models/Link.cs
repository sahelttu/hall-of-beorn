﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class Link
    {
        public Link(LinkType type, Card card)
        {
            this.Type = type;
            this.Title = getTitle(type);
            this.Text = this.Title;
            this.Url = getUrl(type, card, defaltLanguage);
        }

        private const string defaltLanguage = "en";

        private static string getUrl(LinkType type, Card card, string language)
        {
            var title = card.Title.ToUrlSafeString();

            switch (type)
            {
                case LinkType.Dor_Cuarthol:
                    return string.Format("https://dorcuarthol.wordpress.com/?s={0}", title);
                case LinkType.Encyclopedia_of_Arda:
                    return string.Format("http://www.glyphweb.com/arda/search.asp?search={0}", title);
                case LinkType.Hall_of_Beorn:
                    return string.Format("http://hallofbeorn.wordpress.com/?s={0}", title);
                case LinkType.Lord_of_the_Rings_Wiki:
                    return string.Format("http://lotr.wikia.com/wiki/{0}", title);
                case LinkType.Master_of_Lore:
                    return string.Format("http://masteroflore.wordpress.com/?s={0}", title);
                case LinkType.Second_Hand_Took:
                    return string.Format("http://secondhandtook.wordpress.com/?s={0}", title);
                case LinkType.Tales_from_the_Cards:
                    return string.Format("http://talesfromthecards.wordpress.com/?s={0}", title);
                case LinkType.Tolkien_Gateway:
                    return string.Format("http://tolkiengateway.net/wiki/{0}", title);
                case LinkType.Wikipedia:
                    return string.Format("https://en.wikipedia.org/wiki/{0}", title);
                default:
                    return string.Empty;
            }
        }

        private static string getTitle(LinkType type)
        {
            return type.ToString().Replace('_', ' ');
        }

        public LinkType Type { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
    }
}