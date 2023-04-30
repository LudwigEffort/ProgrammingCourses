<?php

namespace App\Http\Controllers;

use App\Movie;

use Illuminate\Http\Request;



class HomeController extends Controller
{
    public function home() {
        return view('guest.home');
    }

    public function news() {
        return view('guest.news');
    }

    public function contacts() {
        return view('guest.contacts');
    }

    public function list() {

        $movies = Movie::all();

        dump($movies);

        return view('guest.list', [
            'movies' => $movies,
        ]);
    }
}
