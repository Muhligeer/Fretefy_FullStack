import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeModule } from './modules/home/home.module';
import { ToolbarModule } from './components/toolbar/toolbar.module';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { RegiaoModule } from './modules/regiao/regiao.module';
import { RegioesService } from './services/regioes.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    HomeModule,
    ToolbarModule,
    RegiaoModule,
    AppRoutingModule
  ],
  providers: [RegioesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
