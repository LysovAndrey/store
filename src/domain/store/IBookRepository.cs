using System;
using System.Collections.Generic;
using System.Text;

namespace store
{
	interface IBookRepository
	{
		Book[] GetAllByTitle(string titlePart);
	}
}
