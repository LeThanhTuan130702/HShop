import { authGuard, permissionGuard } from '@abp/ng.core';
import { Routes } from '@angular/router';
import { Dashboard } from './pages/dashboard/dashboard';
import { Documentation } from './pages/documentation/documentation';

export const APP_ROUTES: Routes = [
  // {
  //   path: '',
  //   pathMatch: 'full',
  //   loadComponent: () => import('./home/home.component').then(c => c.HomeComponent),
  // },
  {
    path: '',
    pathMatch: 'full',
    loadComponent: () => import('./layout/component/app.layout').then(c => c.AppLayout),
    children: [
      { path: '', component: Dashboard },
      { path: 'uikit', loadChildren: () => import('./pages/uikit/uikit.routes') },
      { path: 'documentation', component: Documentation },
      { path: 'pages', loadChildren: () => import('./pages/pages.routes') },
    ],
  },

  {
    path: 'auth',
    loadChildren: () => import('./pages/auth/auth.routes'),
  },
  {
    path: 'account',
    loadChildren: () => import('@abp/ng.account').then(c => c.createRoutes()),
  },
  {
    path: 'identity',
    loadChildren: () => import('@abp/ng.identity').then(c => c.createRoutes()),
  },
  {
    path: 'tenant-management',
    loadChildren: () => import('@abp/ng.tenant-management').then(c => c.createRoutes()),
  },
  {
    path: 'setting-management',
    loadChildren: () => import('@abp/ng.setting-management').then(c => c.createRoutes()),
  },
  {
    path: 'books',
    loadComponent: () => import('./book/book.component').then(c => c.BookComponent),
    canActivate: [authGuard, permissionGuard],
  },
];
