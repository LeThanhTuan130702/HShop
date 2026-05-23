import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:5000/',
  redirectUri: baseUrl,
  clientId: 'BookStore_Admin_App',
  responseType: 'code',
  scope: 'offline_access BookStore.Admin',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'BookStore Admin',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:5002',
      rootNamespace: 'Acme.BookStore.Admin',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
