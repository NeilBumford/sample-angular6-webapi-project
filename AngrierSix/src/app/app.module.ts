import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { RoomDetailsCreateComponent } from './components/room-details-create/room-details-create.component';
import { RoomDetailsDetailComponent } from './components/room-details-detail/room-details-detail.component';
import { RoutingModule } from './app.routing';

@NgModule({
  declarations: [
    AppComponent,
    RoomDetailsCreateComponent,
    RoomDetailsDetailComponent
  ],
  imports: [
    BrowserModule,
    RoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
