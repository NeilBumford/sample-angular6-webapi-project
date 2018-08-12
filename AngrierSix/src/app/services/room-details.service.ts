import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class RoomDetailsService {
  API_URL = 'http://localhost:5000/api';
  constructor(private httpClient: HttpClient) { }

  getRoomDetails() {
    return this.httpClient.get(`${this.API_URL}/room`);
  }
}
