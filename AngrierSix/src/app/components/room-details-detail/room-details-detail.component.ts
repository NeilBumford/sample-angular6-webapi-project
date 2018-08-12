import { Component, OnInit } from '@angular/core';
import { RoomDetailsService } from '../../services/room-details.service';

@Component({
  selector: 'app-room-details-detail',
  templateUrl: './room-details-detail.component.html',
  styleUrls: ['./room-details-detail.component.css']
})
export class RoomDetailsDetailComponent implements OnInit {
  //public roomDetails = {};
  public roomDetails;
  public test = "Hello";

  constructor(private roomDetailsService: RoomDetailsService) { }

  ngOnInit() {
    this.getRoomDetails();
  }

  public getRoomDetails() {
    this.roomDetailsService.getRoomDetails().subscribe(data => {
      this.roomDetails = data;
      console.log(data);
    });
  }
}
