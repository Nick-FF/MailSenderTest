using System;

namespace MailSender
{
	public static class Ext
	{
        public static string MyFormat(this string self, params object[] args) => String.Format(self, args);
    }
}