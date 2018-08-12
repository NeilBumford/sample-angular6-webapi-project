import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Room } from '../models/Room';

@Injectable({
  providedIn: 'root'
})
export class RoomDetailsService {
  API_URL = 'http://localhost:5000/api';
  constructor(private httpClient: HttpClient) { }

  getRoomDetails() {
    return this.httpClient.get(`${this.API_URL}/room`);
  }

  calculate(room: Room) {
    return this.httpClient.post(`${this.API_URL}/room`, room);
  }
}
