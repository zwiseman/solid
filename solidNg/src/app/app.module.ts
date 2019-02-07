import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Services } from 'services/index';
import { Components } from 'components/index';
@NgModule({
  declarations: [
    AppComponent,
    Components
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [ Services],
  bootstrap: [AppComponent]
})
export class AppModule { }
