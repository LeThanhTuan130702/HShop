import { Component } from '@angular/core';
import { LoaderBarComponent } from '@abp/ng.theme.shared';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  template: `
    <abp-loader-bar />
    <router-outlet></router-outlet>
  `,
  imports: [LoaderBarComponent, RouterModule],
})
export class AppComponent {}
