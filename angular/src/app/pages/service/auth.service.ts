import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginRequestDto } from '../models/LoginRequest.dto';
import { LoginResponseDto } from '../models/LoginResponse.dto';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class Authservice {
  constructor(private httpClient: HttpClient) {}
  public login(input: LoginRequestDto): Observable<LoginResponseDto> {
    var body = {
      userName: input.userName,
      password: input.password,
      clientId: environment.oAuthConfig?.clientId,
      clientSecret: environment.oAuthConfig?.dummyClientSecret,
      grantType: 'password',
      scope: environment.oAuthConfig?.scope,
    };

    const data = Object.keys(body).map(
      (key, index) => `${key}=${encodeURIComponent(body[key as keyof typeof body] ?? '')}`,
    );

    return this.httpClient.post<LoginResponseDto>(
      environment.oAuthConfig?.issuer + 'connect/token',
      data,
      {
        headers: {
          'Content-Type': 'application/x-www-form-urlencoded',
        },
      },
    );
  }
}
