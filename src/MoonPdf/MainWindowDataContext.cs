/*! MoonPdf - A WPF-based PDF Viewer application that uses the MoonPdfLib library
Copyright (C) 2013  (see AUTHORS file)

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
!*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoonPdf
{
	public class MainWindowDataContext
	{
		public Commands Commands { get; private set; }

		public MainWindowDataContext(MainWindow wnd)
		{
			this.Commands = new Commands(wnd, this);
		}

		private byte[] _data;

		public byte[] Data
		{
			get { return _data; }
			set { _data = value; }
		}

	}
}
