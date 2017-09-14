Rails.application.routes.draw do
  resources :sections
  resources :courses
  resources :professors
  # For details on the DSL available within this file, see http://guides.rubyonrails.org/routing.html
end
