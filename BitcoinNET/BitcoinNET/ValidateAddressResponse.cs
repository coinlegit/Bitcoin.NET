﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitcoinNET
{
	public struct ValidateAddressResponse
	{
		public bool isvalid;
		public string address;
		public bool ismine;
		public string pubkey;
		public bool iscompressed;
		public string account;
	}
}
