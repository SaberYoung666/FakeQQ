using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeQQ
{
    internal class Friends
    {
        public String name;
        public Image avatar;
        public string account;
        public Boolean online_status;

        public Friends(string account, string name, Image avatar, bool online_status)
		{
			this.account = account;
			this.name = name;
			this.avatar = avatar;
			this.online_status = online_status;
		}
	}
}
