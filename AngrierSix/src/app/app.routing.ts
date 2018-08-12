//import { ModuleWithProviders } from '@angular/core';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { RoomDetailsCreateComponent } from './components/room-details-create/room-details-create.component';
import { RoomDetailsDetailComponent } from './components/room-details-detail/room-details-detail.component';

const routes: Routes = [
  { path: 'room-details', component: RoomDetailsDetailComponent },
  { path: 'add-room-details', component: RoomDetailsCreateComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

//export const RoutingModule: ModuleWithProviders = RouterModule.forRoot(routes);
export class RoutingModule { }
