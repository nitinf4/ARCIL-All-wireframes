@import url("https://fonts.googleapis.com/css2?family=Readex+Pro:wght@300;400;500&display=swap");
body {
  letter-spacing: 0.6px;
  font-family: "Readex Pro", sans-serif !important;
  font-weight: 300 !important;
  font-size: 14px !important;
  counter-reset: my-sec-counter;
}

a {
  text-decoration: none !important;
}

.fwt-normal {
  font-weight: 500 !important;
}

.bi {
  display: inline-block;
  width: 1rem;
  height: 1rem;
}

input,
select,
textarea {
  font-size: 14px !important;
}

.label-wrapper {
  position: relative;
}
.label-wrapper input {
  max-width: 110px;
  padding: 4px 8px 4px 26px;
  border-radius: 4px;
  border: 1px solid #ccc;
}
.label-wrapper select {
  width: 105px;
  padding: 4px 32px 4px 26px;
  border-radius: 4px;
  border: 1px solid #ccc;
}
.label-wrapper::after {
  content: "";
  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='42' height='42' viewBox='0 0 42 42' fill='none'%3E%3Cg clip-path='url(%23clip0_862_172)'%3E%3Cpath fill-rule='evenodd' clip-rule='evenodd' d='M17.6662 32.0906C9.41061 32.0906 2.71821 25.515 2.71821 17.3906C2.71821 9.26625 9.41061 2.67755 17.6662 2.67755C25.9219 2.67755 32.6156 9.26625 32.6156 17.3906C32.6156 25.515 25.9219 32.0906 17.6662 32.0906ZM41.5905 39.7031L30.7505 29.0325C33.5882 25.9481 35.3325 21.8794 35.3325 17.3906C35.3325 7.78313 27.4234 0 17.6662 0C7.90911 0 0 7.78313 0 17.3906C0 26.985 7.90911 34.7681 17.6662 34.7681C21.882 34.7681 25.7486 33.3113 28.7858 30.8832L39.669 41.5931C40.2006 42.1181 41.0602 42.1181 41.5905 41.5931C42.1221 41.0812 42.1221 40.2281 41.5905 39.7031Z' fill='%23bbb'/%3E%3C/g%3E%3Cdefs%3E%3CclipPath id='clip0_862_172'%3E%3Crect width='42' height='42' fill='white'/%3E%3C/clipPath%3E%3C/defs%3E%3C/svg%3E");
  background-size: contain;
  background-position: 100%;
  height: 14px;
  width: 14px;
  position: absolute;
  top: 50%;
  left: 7px;
  transform: translateY(-50%);
}

.dropdown .dropdown-item {
  font-size: 14px;
}

.terms-wrap {
  height: 300px;
  overflow: auto;
  padding-right: 20px;
}

.navbar {
  background-color: #f5f5f5;
  box-shadow: 0 0.2rem 0.5rem rgba(0, 0, 0, 0.15) !important;
}

.navbar-brand {
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
  background-color: #fff !important;
}
.navbar-brand .logo {
  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' xmlns:serif='http://www.serif.com/' width='100%25' height='100%25' viewBox='0 0 1200 800' version='1.1' xml:space='preserve' style='fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;'%3E%3Crect id='Artboard1' x='0' y='0' width='1200' height='800' style='fill:none;'/%3E%3CclipPath id='_clip1'%3E%3Crect id='Artboard11' serif:id='Artboard1' x='0' y='0' width='1200' height='800'/%3E%3C/clipPath%3E%3Cg clip-path='url(%23_clip1)'%3E%3Crect x='94.53' y='118.488' width='330.047' height='509.712' style='fill:%23018ccd;'/%3E%3Crect x='135.372' y='47.885' width='248.364' height='413.491' style='fill:%2329166f;'/%3E%3Cg%3E%3Cpath d='M607.196,678.151c8.591,0 14.524,1.613 17.799,4.839c3.276,3.226 4.913,8.904 4.913,17.035c0,3.785 -0.436,7.134 -1.308,10.047c-0.873,2.913 -2.148,5.226 -3.827,6.938c-1.646,1.711 -3.563,2.929 -5.752,3.653c-2.189,0.724 -5.802,1.087 -10.838,1.087l-9.579,-0l0,29.23l-15.898,-0l-0,-72.829l24.49,0Zm-8.789,11.455l-0,20.442l5.036,-0c4.411,-0 7.349,-0.741 8.814,-2.222c1.464,-1.481 2.197,-4.214 2.197,-8.196c-0,-3.786 -0.683,-6.403 -2.049,-7.851c-1.366,-1.448 -3.909,-2.173 -7.629,-2.173l-6.369,0Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M635.932,750.98l-0,-50.857l12.442,0l0.939,6.666c0.921,-2.502 2.452,-4.427 4.591,-5.777c2.14,-1.35 4.757,-2.024 7.851,-2.024l0.889,-0l-0,12.343l-1.284,0c-3.983,0 -6.838,0.947 -8.567,2.839c-1.728,1.893 -2.592,5.061 -2.592,9.505l0,27.305l-14.269,-0Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M682.888,719.133l12.738,-0l0,-4.247c0,-2.403 -0.551,-4.271 -1.654,-5.604c-1.102,-1.333 -2.641,-1.999 -4.616,-1.999c-2.14,-0 -3.753,0.847 -4.839,2.542c-1.086,1.696 -1.629,4.222 -1.629,7.58l-0,1.728Zm12.936,13.035l14.17,-0c0,6.649 -1.719,11.636 -5.159,14.96c-3.44,3.325 -8.6,4.987 -15.479,4.987c-7.867,0 -13.34,-1.958 -16.417,-5.875c-3.078,-3.918 -4.617,-11.176 -4.617,-21.775c-0,-9.118 1.629,-15.644 4.888,-19.577c3.259,-3.934 8.641,-5.9 16.146,-5.9c6.978,-0 12.162,1.687 15.553,5.061c3.39,3.374 5.085,8.5 5.085,15.38l0,7.702l-27.106,0l-0,5.234c-0,3.819 0.502,6.592 1.506,8.32c1.003,1.728 2.625,2.592 4.863,2.592c2.14,0 3.769,-0.864 4.888,-2.592c1.119,-1.728 1.679,-4.255 1.679,-7.579l-0,-0.938Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M733.003,705.456c1.152,-2.107 2.691,-3.712 4.617,-4.814c1.925,-1.103 4.172,-1.654 6.74,-1.654c3.291,-0 6.056,0.674 8.295,2.024c2.238,1.35 3.818,3.275 4.74,5.777c1.316,-2.601 2.979,-4.551 4.986,-5.851c2.008,-1.3 4.362,-1.95 7.061,-1.95c4.444,-0 7.842,1.143 10.196,3.431c2.354,2.288 3.53,5.604 3.53,9.949l0,38.612l-14.269,-0l-0,-34.662c-0,-3.357 -0.346,-5.637 -1.037,-6.838c-0.691,-1.202 -1.893,-1.802 -3.604,-1.802c-1.844,-0 -3.333,0.658 -4.469,1.975c-1.135,1.316 -1.703,3.061 -1.703,5.233l-0,36.094l-14.27,-0l0,-34.662c0,-3.291 -0.353,-5.554 -1.061,-6.789c-0.708,-1.234 -1.934,-1.851 -3.679,-1.851c-1.843,-0 -3.316,0.65 -4.419,1.95c-1.102,1.3 -1.654,3.053 -1.654,5.258l0,36.094l-14.269,-0l-0,-41.673c-0,-2.337 -0.033,-4.139 -0.099,-5.407c-0.066,-1.267 -0.181,-2.493 -0.346,-3.678l14.319,0l0.395,5.234Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M807.313,700.222l-0,50.758l-14.27,-0l0,-50.758l14.27,0Zm-0,-22.071l-0,12.048l-14.27,-0l0,-12.048l14.27,0Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M830.667,719.133l12.739,-0l-0,-4.247c-0,-2.403 -0.551,-4.271 -1.654,-5.604c-1.103,-1.333 -2.642,-1.999 -4.617,-1.999c-2.139,-0 -3.752,0.847 -4.839,2.542c-1.086,1.696 -1.629,4.222 -1.629,7.58l0,1.728Zm12.936,13.035l14.171,-0c0,6.649 -1.72,11.636 -5.16,14.96c-3.439,3.325 -8.599,4.987 -15.479,4.987c-7.867,0 -13.339,-1.958 -16.417,-5.875c-3.078,-3.918 -4.617,-11.176 -4.617,-21.775c0,-9.118 1.63,-15.644 4.889,-19.577c3.258,-3.934 8.64,-5.9 16.145,-5.9c6.979,-0 12.163,1.687 15.553,5.061c3.391,3.374 5.086,8.5 5.086,15.38l0,7.702l-27.107,0l0,5.234c0,3.819 0.502,6.592 1.506,8.32c1.004,1.728 2.625,2.592 4.864,2.592c2.139,0 3.768,-0.864 4.888,-2.592c1.119,-1.728 1.678,-4.255 1.678,-7.579l0,-0.938Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M866.513,750.98l0,-50.857l12.443,0l0.938,6.666c0.922,-2.502 2.452,-4.427 4.592,-5.777c2.14,-1.35 4.756,-2.024 7.851,-2.024l0.888,-0l0,12.343l-1.283,0c-3.983,0 -6.839,0.947 -8.567,2.839c-1.728,1.893 -2.592,5.061 -2.592,9.505l-0,27.305l-14.27,-0Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M942.897,723.576l15.553,0l-7.555,-31.55l-7.998,31.55Zm22.218,27.404l-3.9,-16.195l-21.133,-0l-3.851,16.195l-15.306,-0l20.54,-72.829l19.404,0l20.244,72.829l-15.998,-0Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M1010.34,678.151c8.92,0 14.977,1.35 18.17,4.049c3.193,2.699 4.789,7.587 4.789,14.665c0,5.595 -0.814,9.776 -2.444,12.541c-1.629,2.765 -4.353,4.625 -8.171,5.579c4.345,0.889 7.307,2.428 8.887,4.617c1.58,2.189 2.37,6.41 2.37,12.664l-0.148,3.654c0,3.325 0.156,6.18 0.469,8.567c0.313,2.386 0.798,4.55 1.457,6.493l-15.85,-0c-0.691,-2.37 -1.069,-7.176 -1.135,-14.418c-0.033,-2.469 -0.066,-4.378 -0.099,-5.727c-0.099,-3.621 -0.774,-6.172 -2.024,-7.654c-1.251,-1.481 -3.341,-2.221 -6.271,-2.221l-6.369,-0l-0,30.02l-15.257,-0l-0,-72.829l21.626,0Zm-6.369,31.452l3.752,0c4.082,0 6.921,-0.773 8.517,-2.32c1.597,-1.547 2.395,-4.247 2.395,-8.098c-0,-3.719 -0.724,-6.262 -2.173,-7.628c-1.448,-1.366 -4.262,-2.049 -8.443,-2.049l-4.048,-0l-0,20.095Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M1091.61,726.095c0.066,0.395 0.107,0.822 0.124,1.283c0.016,0.461 0.024,1.152 0.024,2.074c0,7.242 -1.958,12.829 -5.875,16.763c-3.917,3.933 -9.513,5.9 -16.788,5.9c-3.357,0 -6.493,-0.444 -9.406,-1.333c-2.913,-0.889 -5.242,-2.107 -6.986,-3.654c-2.996,-2.6 -5.119,-6.287 -6.37,-11.06c-1.25,-4.773 -1.876,-12.508 -1.876,-23.206c0,-7.34 0.387,-13.035 1.16,-17.084c0.774,-4.048 2.066,-7.422 3.876,-10.122c1.811,-2.732 4.387,-4.814 7.728,-6.246c3.341,-1.431 7.266,-2.147 11.776,-2.147c7.373,-0 12.928,1.876 16.664,5.628c3.736,3.753 5.604,9.332 5.604,16.739l-0,1.382l-15.257,0l-0,-1.382c-0,-3.852 -0.601,-6.707 -1.802,-8.567c-1.202,-1.86 -3.037,-2.79 -5.506,-2.79c-3.423,0 -5.777,1.63 -7.06,4.888c-1.284,3.259 -1.926,10.83 -1.926,22.713c-0,9.974 0.667,16.615 2,19.923c1.333,3.308 3.728,4.962 7.184,4.962c2.469,-0 4.32,-1.004 5.554,-3.012c1.235,-2.008 1.852,-5.053 1.852,-9.134l-0.099,-2.518l15.405,-0Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3C/g%3E%3Cg%3E%3Cpath d='M456.228,354.791l36.488,-0l-0,39.775c10.887,-15.677 22.369,-27.393 34.446,-35.147c12.078,-7.755 24.666,-11.633 37.764,-11.633c9.866,0 20.413,3.085 31.64,9.256l-18.627,29.519c-7.485,-3.169 -13.779,-4.753 -18.882,-4.753c-11.907,-0 -23.389,4.795 -34.446,14.384c-11.057,9.589 -19.477,24.474 -25.261,44.653c-4.423,15.51 -6.634,46.864 -6.634,94.06l-0,92.059l-36.488,0l0,-272.173Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M884.337,409.806l-27.398,17.714c-23.667,-32.689 -55.963,-49.033 -96.89,-49.033c-32.707,-0 -59.866,10.94 -81.479,32.821c-21.612,21.882 -32.418,48.464 -32.418,79.749c-0,20.345 4.971,39.492 14.915,57.441c9.944,17.949 23.585,31.881 40.925,41.797c17.339,9.916 36.774,14.873 58.304,14.873c39.446,0 71.66,-16.344 96.643,-49.033l27.398,18.741c-12.835,20.104 -30.072,35.698 -51.71,46.783c-21.638,11.084 -46.279,16.626 -73.924,16.626c-42.453,-0 -77.667,-14.034 -105.64,-42.102c-27.974,-28.068 -41.961,-62.211 -41.961,-102.43c0,-27.041 6.541,-52.157 19.623,-75.347c13.082,-23.19 31.059,-41.289 53.931,-54.296c22.872,-13.007 48.46,-19.51 76.762,-19.51c17.772,-0 34.926,2.824 51.463,8.471c16.537,5.648 30.565,13.008 42.084,22.078c11.518,9.071 21.309,20.623 29.372,34.657Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Cpath d='M966.71,239.89c7.942,0 14.726,2.835 20.352,8.506c5.625,5.67 8.438,12.508 8.438,20.513c-0,7.838 -2.813,14.592 -8.438,20.263c-5.626,5.67 -12.41,8.505 -20.352,8.505c-7.777,0 -14.478,-2.835 -20.103,-8.505c-5.626,-5.671 -8.438,-12.425 -8.438,-20.263c-0,-8.005 2.812,-14.843 8.438,-20.513c5.625,-5.671 12.326,-8.506 20.103,-8.506Zm-19.488,114.901l40.299,-0l-0,273.409l-40.299,0l-0,-273.409Z' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3Crect x='1050.64' y='245.166' width='41.121' height='383.495' style='fill:%2329166f;fill-rule:nonzero;'/%3E%3C/g%3E%3Cpath d='M131.584,628.2l-37.054,0l165.023,-416.982l165.024,416.982l-37.054,0l-52.449,-136.376l-149.273,-0l-54.217,136.376Zm128.177,-324.016l61.72,157.192l-123.855,-0l62.135,-157.192Z' style='fill:%23fff;'/%3E%3Crect x='-0' y='-0' width='1200' height='800' style='fill:none;'/%3E%3C/g%3E%3C/svg%3E");
  background-size: auto 100%;
  background-position: left;
  background-repeat: no-repeat;
  width: 83px;
  height: 53px;
  display: block;
}
@media (max-width: 480px) {
  .navbar-brand .logo {
    width: 100px;
  }
}

.feather {
  width: 16px;
  height: 16px;
  vertical-align: text-bottom;
}

.sidebar {
  position: fixed;
  top: 0;
  bottom: 0;
  left: 0;
  z-index: 100;
  padding: 73px 0 0;
  box-shadow: inset -1px 0 0 rgba(0, 0, 0, 0.1);
}
@media (max-width: 480px) {
  .sidebar {
    padding: 85px 0 0;
    top: -10px !important;
  }
}

.userdetail {
  display: flex;
}

@media (max-width: 767.98px) {
  .sidebar {
    top: 5rem;
  }
  .userdetail {
    display: none;
  }
}
@media (min-width: 768px) {
  .userinfo {
    display: none !important;
    visibility: hidden !important;
  }
}
.userinfo {
  display: none !important;
  visibility: hidden !important;
}
.userinfo li {
  display: flex;
  flex-direction: column;
  margin-left: 14px;
  gap: 5px;
}

@media (max-width: 767.98px) {
  .userinfo {
    display: block !important;
    visibility: visible !important;
  }
}
.sidebar-sticky {
  position: relative;
  top: 0;
  height: calc(100vh - 48px);
  padding-top: 0.5rem;
  overflow-x: hidden;
  overflow-y: auto;
}

.sidebar .nav-link {
  font-weight: 500;
  color: #333;
}

.sidebar .nav-link .feather {
  margin-right: 4px;
  color: #727272;
}

.sidebar .nav-link.active {
  color: #fff;
  background-color: #0d6efd;
}

.sidebar .nav-link.active svg {
  fill: #fff;
}

.sidebar .nav-link:hover .feather,
.sidebar .nav-link.active .feather {
  color: inherit;
}

.sidebar-heading {
  font-size: 0.75rem;
  text-transform: uppercase;
}

.navbar-brand {
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
  font-size: 1rem;
  background-color: rgba(0, 0, 0, 0.25);
  box-shadow: inset -1px 0 0 rgba(0, 0, 0, 0.25);
}

.navbar .navbar-toggler {
  background-color: #bbb;
}

.navbar .form-control {
  padding: 0.75rem 1rem;
  border-width: 0;
  border-radius: 0;
}

.form-control-dark {
  color: #fff;
  background-color: rgba(255, 255, 255, 0.1);
  border-color: rgba(255, 255, 255, 0.1);
}

.form-control-dark:focus {
  border-color: transparent;
  box-shadow: 0 0 0 3px rgba(255, 255, 255, 0.25);
}

.nav-wrap {
  height: 100%;
  flex-direction: column;
}

.table thead tr th {
  padding: 10px 15px !important;
  font-weight: 500;
  border: 1px solid #dee2e6 !important;
}
.table thead tr th .label-wrapper input[type=date] {
  max-width: 100% !important;
}
.table thead tr th .label-wrapper select {
  width: auto;
}
.table tr td {
  padding: 10px 15px !important;
  border: 1px solid #dee2e6 !important;
}

.nowrap {
  white-space: nowrap;
}

.line-limit div {
  overflow: hidden;
  display: -webkit-box;
  -webkit-line-clamp: 2;
  -webkit-box-orient: vertical;
}
.line-limit span {
  overflow: hidden;
  display: -webkit-box;
  -webkit-line-clamp: 1;
  -webkit-box-orient: vertical;
}

.email-pending tbody tr td:nth-child(1) {
  white-space: nowrap;
}
.email-pending tbody tr td:nth-child(2) div {
  overflow: hidden;
  display: -webkit-box;
  -webkit-line-clamp: 2;
  -webkit-box-orient: vertical;
}
.email-pending tbody tr td:nth-child(2) span {
  overflow: hidden;
  display: -webkit-box;
  -webkit-line-clamp: 1;
  -webkit-box-orient: vertical;
}
.email-pending tbody tr td:nth-child(3) {
  white-space: nowrap;
}
.email-pending tbody tr td:nth-child(4) {
  width: 100px;
}

.card-title {
  color: rgba(33, 37, 41, 0.75);
}
.card-title::after {
  content: "";
  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='800px' height='800px' viewBox='0 0 24 24' fill='none'%3E%3Cpath d='M4 12H20M20 12L16 8M20 12L16 16' stroke='%23595c5f' stroke-width='2' stroke-linecap='round' stroke-linejoin='round'/%3E%3C/svg%3E");
  background-repeat: no-repeat;
  background-size: 100%;
  background-position: center center;
  height: 10px;
  width: 22px;
  display: block;
}

.custom-modal {
  display: none;
  position: fixed;
  z-index: 1059;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  overflow: auto;
  background-color: rgba(0, 0, 0, 0.5);
  transition: all 0.4s ease-in-out;
}
.custom-modal .custom-modal-dialog {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 500px;
}
.custom-modal .custom-modal-dialog .custom-modal-content {
  background-color: #fff;
  border-radius: 7px;
}
.custom-modal .custom-modal-dialog .custom-modal-content .custom-modal-body {
  position: relative;
}
.custom-modal .custom-modal-dialog .custom-modal-content .custom-modal-body .custom-close-btn {
  margin-left: auto;
  display: block;
}

/*# sourceMappingURL=style.cs.map */