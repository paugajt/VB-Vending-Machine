class Library < ApplicationRecord
  has_and_belongs_to_many :books
end
