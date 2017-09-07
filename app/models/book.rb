class Book < ApplicationRecord
  has_and_belongs_to_many :libraries
end
