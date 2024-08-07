﻿using System.Windows.Controls;

namespace APP.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    Page GetPage(string key);
}
