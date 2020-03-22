import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent, HomeComponent, TeamListComponent } from './components';
import { TeamDetailsComponent } from './components/team/team-details/team-details.component';
import { routes } from './app.routing';
import { TeamCreateComponent } from './components/team/team-create/team-create.component';
import { ApiAuthorizationModule } from 'src/auth/api-authorization.module';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    TeamListComponent,
    TeamDetailsComponent,
    TeamCreateComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ApiAuthorizationModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
